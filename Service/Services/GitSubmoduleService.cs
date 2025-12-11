
using Core;
using Service.Interfaces;
using System.Text;

namespace Service.Services;

public class GitSubmoduleService : IGitSubmoduleService
{
    // تولید دستورات اصلی و توضیحات
    public GitSubmoduleOutput GenerateCommands(GitSubmoduleInputModel input, string lang = "en")
    {
        var sb = new StringBuilder();
        var expl = new StringBuilder();

        string op = (input.OperationType ?? "add").ToLowerInvariant();

        // Helper: localized phrases (very small localization; you can replace with resource files)
        string t_add = lang.StartsWith("fa") ? "اضافه کردن submodule" : "Add submodule";
        string t_update = lang.StartsWith("fa") ? "آپدیت submodule" : "Update submodule";
        string t_remove = lang.StartsWith("fa") ? "حذف submodule" : "Remove submodule";
        string t_sync = lang.StartsWith("fa") ? "همگام‌سازی submodule" : "Sync submodule urls";
        string t_init = lang.StartsWith("fa") ? "شروع و initialize submodule" : "Init submodules";

        // Sanity checks
        if (op == "add" && string.IsNullOrWhiteSpace(input.RepositoryUrl))
        {
            return new GitSubmoduleOutput
            {
                Commands = "",
                Explanation = lang.StartsWith("fa") ? "برای افزودن submodule باید آدرس مخزن را وارد کنید." : "Repository URL is required to add a submodule."
            };
        }

        // ADD
        if (op == "add")
        {
            sb.AppendLine($"# {t_add}");
            sb.AppendLine($"git submodule add {input.RepositoryUrl} {input.LocalPath}".Trim());
            if (!string.IsNullOrWhiteSpace(input.Reference))
            {
                // checkout the given reference inside submodule
                sb.AppendLine($"cd {input.LocalPath}");
                sb.AppendLine($"git fetch --all");
                sb.AppendLine($"git checkout {input.Reference}");
                sb.AppendLine($"cd -");
            }

            expl.AppendLine(lang.StartsWith("fa")
                ? $"این دستور یک زیرمخزن در مسیر `{input.LocalPath}` می‌سازد و فایل `.gitmodules` را بروز می‌کند."
                : $"Adds a submodule at `{input.LocalPath}` and updates `.gitmodules`.");

            if (input.Recursive)
            {
                sb.AppendLine();
                sb.AppendLine("# Initialize and update recursively");
                sb.AppendLine("git submodule update --init --recursive");
                expl.AppendLine(lang.StartsWith("fa")
                    ? "اگر زیرمخزن خودش submodule داشته باشد، با --recursive همه را clone می‌کند."
                    : "If the submodule has nested submodules, `--recursive` will clone them too.");
            }

            // Stage changes and commit if requested
            if (input.AutoCommit)
            {
                sb.AppendLine();
                sb.AppendLine("# Stage and commit the .gitmodules and submodule pointer");
                sb.AppendLine("git add .gitmodules");
                sb.AppendLine($"git add {input.LocalPath}");
                var msg = string.IsNullOrWhiteSpace(input.CommitMessage) ? $"Add submodule {input.LocalPath}" : input.CommitMessage;
                sb.AppendLine($"git commit -m \"{msg}\"");
                if (input.PushToRemote)
                {
                    sb.AppendLine("git push");
                }
            }
        }

        // UPDATE: fetch remote changes and update pointer
        else if (op == "update")
        {
            sb.AppendLine($"# {t_update}");
            if (!string.IsNullOrWhiteSpace(input.LocalPath))
            {
                sb.AppendLine($"cd {input.LocalPath}");
                sb.AppendLine("git fetch origin");
                if (!string.IsNullOrWhiteSpace(input.Reference))
                    sb.AppendLine($"git checkout {input.Reference}");
                else
                    sb.AppendLine("git checkout origin/HEAD || true  # try to update to remote HEAD");

                sb.AppendLine("git pull --ff-only || true");
                sb.AppendLine("cd -");
                sb.AppendLine();
                sb.AppendLine($"git add {input.LocalPath}");
                sb.AppendLine("git commit -m \"Update submodule pointer\"");
                if (input.PushToRemote) sb.AppendLine("git push");
            }
            else
            {
                // update all
                sb.AppendLine("git submodule update --remote");
                if (input.Recursive) sb.AppendLine("git submodule update --remote --recursive");
                if (input.AutoCommit)
                {
                    sb.AppendLine();
                    sb.AppendLine("git add .");
                    sb.AppendLine("git commit -m \"Update submodules to remote\"");
                    if (input.PushToRemote) sb.AppendLine("git push");
                }
            }

            expl.AppendLine(lang.StartsWith("fa")
                ? "آپدیت pointer داخلی به commit جدید در submodule (در branch/commit مشخص). سپس تغییر pointer در repo اصلی commit می‌شود."
                : "Updates submodule pointer to the remote commit, then stages and commits the pointer change in the parent repository.");
        }

        // REMOVE
        else if (op == "remove")
        {
            sb.AppendLine($"# {t_remove}");
            sb.AppendLine($"git submodule deinit -f {input.LocalPath}");
            sb.AppendLine($"git rm -f {input.LocalPath}");
            sb.AppendLine($"rm -rf .git/modules/{input.LocalPath}");
            sb.AppendLine($"git commit -m \"Remove submodule {input.LocalPath}\" || true");
            if (input.PushToRemote) sb.AppendLine("git push");
            expl.AppendLine(lang.StartsWith("fa")
                ? "برای حذف کامل: ابتدا submodule را deinit کنید، سپس آن را از index حذف کنید و در نهایت پوشه modules را پاک کنید."
                : "To fully remove: deinit the submodule, remove it from index, and delete the modules directory.");
        }

        // SYNC
        else if (op == "sync")
        {
            sb.AppendLine($"# {t_sync}");
            sb.AppendLine("git submodule sync --recursive");
            if (input.Recursive) sb.AppendLine("git submodule update --init --recursive");
            expl.AppendLine(lang.StartsWith("fa")
                ? "همگام‌سازی URL های submodule (مثلاً بعد از تغییر URL در .gitmodules یا انتقال repo)."
                : "Sync submodule configuration (useful after URL changes in .gitmodules).");
        }

        // INIT
        else if (op == "init")
        {
            sb.AppendLine($"# {t_init}");
            sb.AppendLine("git submodule init");
            if (input.Recursive) sb.AppendLine("git submodule update --init --recursive");
            expl.AppendLine(lang.StartsWith("fa")
                ? "ابتدا init می‌کند و سپس update اجرا می‌کند (برای cloneهایی که با --recurse-submodules انجام نشده‌اند)."
                : "Initializes and optionally updates recursively (useful when repo was cloned without submodules).");
        }

        // Generic footer explanation
        expl.AppendLine();
        expl.AppendLine(lang.StartsWith("fa")
            ? "نکته: بعد از تغییر pointer در submodule (مثلاً با checkout داخل submodule) فراموش نکنید در repo اصلی آن pointer را commit کنید."
            : "Note: after changing a submodule pointer (e.g. checking out a commit inside submodule), remember to commit that pointer change in the parent repo.");

        return new GitSubmoduleOutput
        {
            Commands = sb.ToString().Trim(),
            Explanation = expl.ToString().Trim()
        };
    }

    // تولید راهکار برای کانفلیکت‌های عمومی در Submodule
    public GitSubmoduleOutput SuggestConflictResolution(GitSubmoduleInputModel input, string lang = "en")
    {
        var sb = new StringBuilder();
        var expl = new StringBuilder();
        string ct = (input.ConflictType ?? "").ToLowerInvariant();

        if (string.IsNullOrEmpty(ct))
        {
            expl.AppendLine(lang.StartsWith("fa")
                ? "یک نوع کانفلیکت انتخاب کنید (detached-head, url-mismatch, pointer-mismatch, modules-dir-missing)."
                : "Choose a conflict type (detached-head, url-mismatch, pointer-mismatch, modules-dir-missing).");
            return new GitSubmoduleOutput { Commands = "", Explanation = expl.ToString() };
        }

        if (ct == "detached-head")
        {
            sb.AppendLine("# Detached HEAD inside submodule: bring it to a branch or set desired commit as pointer");
            sb.AppendLine($"cd {input.LocalPath}");
            sb.AppendLine("git checkout -b <branch-name>   # if you want to create branch");
            sb.AppendLine("git push -u origin <branch-name>");
            sb.AppendLine("cd -");
            sb.AppendLine($"git add {input.LocalPath}");
            sb.AppendLine("git commit -m \"Fix detached HEAD in submodule\"");
            expl.AppendLine(lang.StartsWith("fa")
                ? "وقتی داخل submodule در حالت detached HEAD هستید، یا باید یک شاخه بسازید یا نسخه قابل قبولی را چک‌اوت و pointer را در parent commit کنید."
                : "When the submodule is in detached HEAD, create a branch or checkout a stable branch/commit and then update the parent repo pointer.");
        }
        else if (ct == "url-mismatch")
        {
            sb.AppendLine("# URL mismatch between .gitmodules and .git/config: synchronize");
            sb.AppendLine("git submodule sync --recursive");
            sb.AppendLine("git submodule update --init --recursive");
            sb.AppendLine("# If still mismatch, update .gitmodules and run above again");
            expl.AppendLine(lang.StartsWith("fa")
                ? "اگر URL در .gitmodules متفاوت با config محلی است، ابتدا .gitmodules را تصحیح کنید سپس sync و update را اجرا کنید."
                : "If URLs differ, correct `.gitmodules`, then run sync and update. If necessary, manually edit `.git/config` submodule entry.");
        }
        else if (ct == "pointer-mismatch")
        {
            sb.AppendLine("# Parent pointer mismatch (parent expects commit X but submodule is at Y)");
            sb.AppendLine($"cd {input.LocalPath}");
            sb.AppendLine("git fetch --all");
            sb.AppendLine("git checkout <desired-commit-or-branch>");
            sb.AppendLine("cd -");
            sb.AppendLine($"git add {input.LocalPath}");
            sb.AppendLine("git commit -m \"Align submodule pointer to desired commit\"");
            expl.AppendLine(lang.StartsWith("fa")
                ? "اختلاف بین commit pointer در parent و وضعیت فعلی زیرمخزن معمول است؛ داخل زیرمخزن به commit مورد نظر بروید و سپس parent را update کنید."
                : "Align submodule commit with what parent expects by checking out the desired commit inside the submodule, then commit pointer change in parent.");
        }
        else if (ct == "modules-dir-missing")
        {
            sb.AppendLine("# Modules dir missing (common after manual deletion)");
            sb.AppendLine("rm -rf .git/modules/<path>    # cleanup if corrupted");
            sb.AppendLine("git submodule sync --recursive");
            sb.AppendLine("git submodule update --init --recursive");
            expl.AppendLine(lang.StartsWith("fa")
                ? ".git/modules ممکن است خراب شده باشد. آن را پاک کنید و submodule را مجدد sync و update کنید."
                : "If `.git/modules/<path>` is missing or corrupted, remove it and re-run sync/update.");
        }
        else
        {
            expl.AppendLine(lang.StartsWith("fa")
                ? "نوع کانفلیکت شناخته نشده؛ موارد معمول: detached-head, url-mismatch, pointer-mismatch, modules-dir-missing."
                : "Unknown conflict type; common types: detached-head, url-mismatch, pointer-mismatch, modules-dir-missing.");
        }

        return new GitSubmoduleOutput { Commands = sb.ToString().Trim(), Explanation = expl.ToString().Trim() };
    }
}
