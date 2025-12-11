namespace Core;

public class StashCommandModel
{
    public string TitleEn => "Stash Changes";
    public string TitleFa => "ذخیره موقت تغییرات";

    public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git stash [options] [<message>]</pre>

<h4>What is Git Stash?</h4>
<p>Git stash allows you to temporarily save changes in your working directory without committing them. This is useful when you need to switch branches or pull updates without committing unfinished work.</p>

<h4>Common Use Cases</h4>
<ul>
    <li>Saving work-in-progress (WIP) changes before switching branches.</li>
    <li>Pulling new changes from a remote repository while keeping local modifications.</li>
    <li>Stashing untracked or ignored files temporarily to clean your working directory.</li>
    <li>Saving changes to revisit later without committing them.</li>
</ul>

<h4>Examples</h4>
<pre>
# Save changes with default message
git stash

# Save with custom message
git stash save 'WIP: new feature'

# List stashes
git stash list

# Apply last stash
git stash apply

# Apply a specific stash
git stash apply stash@{2}

# Pop (apply + remove) last stash
git stash pop

# Drop a specific stash
git stash drop stash@{1}

# Clear all stashes
git stash clear

# Stash only untracked files
git stash -u

# Stash including ignored files
git stash -a
</pre>

<h4>What Does Git Stash Do?</h4>
<p>Git stash temporarily saves your local changes (both staged and unstaged) and reverts your working directory to the state of the last commit. It allows you to switch branches or pull without losing your work.</p>

<h4>Comparison with Commit and Merge</h4>
<table style=""border-collapse: collapse; width: 100%; margin-top: 20px;"">
    <thead>
        <tr style=""background-color: #f2f2f2; font-weight: bold;"">
            <th style=""padding: 12px; text-align: left; border: 1px solid #ddd;"">Feature</th>
            <th style=""padding: 12px; text-align: left; border: 1px solid #ddd;"">Commit</th>
            <th style=""padding: 12px; text-align: left; border: 1px solid #ddd;"">Git Stash</th>
            <th style=""padding: 12px; text-align: left; border: 1px solid #ddd;"">Merge</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td style=""padding: 10px; border: 1px solid #ddd;""><strong>Purpose</strong></td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">Saves changes permanently to your branch.</td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">Saves changes temporarily for later use.</td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">Merges branches without saving or hiding changes.</td>
        </tr>
        <tr>
            <td style=""padding: 10px; border: 1px solid #ddd;""><strong>Scope</strong></td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">Affects the entire commit history.</td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">Only affects the working directory, not the commit history.</td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">Affects both branches being merged, integrating changes into one.</td>
        </tr>
        <tr>
            <td style=""padding: 10px; border: 1px solid #ddd;""><strong>When to Use</strong></td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">When you're ready to permanently save your work.</td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">When you need temporary storage for changes while you work on something else.</td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">When you want to combine the changes from two branches into one.</td>
        </tr>
        <tr>
            <td style=""padding: 10px; border: 1px solid #ddd;""><strong>Data Retention</strong></td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">Permanent unless reset or reverted.</td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">Temporary unless applied or popped.</td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">Permanent changes to both branches.</td>
        </tr>
    </tbody>
</table>

<h4>In Simple Terms</h4>
<p>Git stash is like a temporary storage for your work. You put your changes on a shelf (stash), switch to a different branch to do something else, and then come back to the shelf when you're ready to continue where you left off.</p>

<h4>Common Mistakes</h4>
<ul>
    <li>Not remembering to apply or pop stashes, causing the work to be lost.</li>
    <li>Using stash for untracked files without specifying the correct options.</li>
    <li>Stashing large or unimportant files without cleaning them up later.</li>
</ul>

<h2>Best Practices</h2>
<ul>
    <li>Use descriptive messages when stashing changes to remember why you saved them.</li>
    <li>Clear unnecessary stashes regularly to keep your stash list clean.</li>
    <li>Only stash untracked files if you’re sure they are important and need temporary storage.</li>
    <li>Use the `--patch` option for more granular control over what gets stashed, especially for partial changes.</li>
    <li>Before popping a stash, ensure that your working directory is clean and doesn’t have conflicting changes.</li>
</ul>

<h2>Limitations</h2>
<ul>
    <li>Stashed changes are temporary and may be lost if not applied or popped.</li>
    <li>Git stash doesn't include untracked or ignored files unless explicitly specified.</li>
    <li>Conflicts may occur when applying stashes, requiring manual resolution.</li>
</ul>

<h3>How to Use</h3>
<p>Git stash is straightforward to use. Simply run `git stash` to save your changes. Use the `git stash list` command to view all stashes. You can apply or pop a stash with `git stash apply` or `git stash pop`. Optionally, include a custom message to describe the stash.</p>

<h2>Overview</h2>
<p>Git stash is a powerful tool for developers who need to temporarily save their changes without committing them. Whether you're switching branches or pulling updates from a remote, `git stash` helps you keep your working directory clean while saving your work for later.</p>

<h4>Options</h4>
<ul>
    <li>-u, --include-untracked : Include untracked files</li>
    <li>-a, --all : Include all files including ignored</li>
    <li>save &lt;message&gt; : Save with custom message</li>
    <li>apply [stash] : Apply a stash</li>
    <li>pop [stash] : Apply and remove a stash</li>
    <li>list : List stashes</li>
    <li>drop &lt;stash&gt; : Remove a specific stash</li>
    <li>clear : Remove all stashes</li>
    <li>-k, --keep-index : Keep staged changes</li>
    <li>--patch : Stash interactively per hunk</li>
</ul>";

    public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git stash [گزینه‌ها] [<پیام>]</pre>

<h4>Git Stash چیست؟</h4>
<p>Git stash اجازه می‌دهد تغییرات موجود در working directory را بدون commit موقتاً ذخیره کنید. این برای زمانی که می‌خواهید شاخه را تغییر دهید یا pull کنید بدون commit کار نیمه‌تمام مفید است.</p>

<h4>موارد کاربرد رایج</h4>
<ul>
    <li>ذخیره تغییرات نیمه‌تمام قبل از تغییر شاخه.</li>
    <li>پول (Pull) کردن تغییرات جدید از مخزن بدون از دست دادن تغییرات محلی.</li>
    <li>ذخیره موقت فایل‌های untracked یا ignored برای پاک‌سازی working directory.</li>
    <li>ذخیره تغییرات برای مراجعه به آنها در آینده بدون commit کردن.</li>
</ul>

<h4>مثال‌ها</h4>
<pre>
# Save changes with default message
git stash

# Save with custom message
git stash save 'WIP: new feature'

# List stashes
git stash list

# Apply last stash
git stash apply

# Apply a specific stash
git stash apply stash@{2}

# Pop (apply + remove) last stash
git stash pop

# Drop a specific stash
git stash drop stash@{1}

# Clear all stashes
git stash clear

# Stash only untracked files
git stash -u

# Stash including ignored files
git stash -a
</pre>

<h4>دقیقاً چه می‌کند؟</h4>
<p>Git stash تغییرات محلی شما را به‌طور موقت ذخیره می‌کند و working directory شما را به وضعیت آخرین commit باز می‌گرداند. این ابزار برای زمانی مفید است که می‌خواهید شاخه را تغییر دهید یا pull کنید بدون از دست دادن تغییرات.</p>

<h4>مقایسه</h4>
<table style=""border-collapse: collapse; width: 100%; margin-top: 20px;"">
    <thead>
        <tr style=""background-color: #f2f2f2; font-weight: bold;"">
            <th style=""padding: 12px; text-align: left; border: 1px solid #ddd;"">ویژگی</th>
            <th style=""padding: 12px; text-align: left; border: 1px solid #ddd;"">Commit</th>
            <th style=""padding: 12px; text-align: left; border: 1px solid #ddd;"">Git Stash</th>
            <th style=""padding: 12px; text-align: left; border: 1px solid #ddd;"">Merge</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td style=""padding: 10px; border: 1px solid #ddd;""><strong>هدف</strong></td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">تغییرات را دائماً در شاخه ذخیره می‌کند.</td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">تغییرات را موقتاً ذخیره کرده و شما را قادر می‌سازد تا آنها را بعداً اعمال یا حذف کنید.</td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">شاخه‌ها را ترکیب می‌کند اما تغییرات را ذخیره یا پنهان نمی‌کند مانند stash.</td>
        </tr>
        <tr>
            <td style=""padding: 10px; border: 1px solid #ddd;""><strong>دامنه</strong></td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">بر روی کل تاریخچه کامیت تأثیر می‌گذارد.</td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">فقط بر روی working directory تأثیر دارد و تاریخچه کامیت را تغییر نمی‌دهد.</td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">بر روی هر دو شاخه تأثیر می‌گذارد و تغییرات را ترکیب می‌کند.</td>
        </tr>
        <tr>
            <td style=""padding: 10px; border: 1px solid #ddd;""><strong>زمان استفاده</strong></td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">زمانی که آماده‌اید تغییرات خود را دائماً ذخیره کنید.</td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">زمانی که به ذخیره موقت تغییرات نیاز دارید تا کارهای دیگری انجام دهید.</td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">زمانی که می‌خواهید تغییرات دو شاخه را در یک شاخه ترکیب کنید.</td>
        </tr>
        <tr>
            <td style=""padding: 10px; border: 1px solid #ddd;""><strong>نگهداری داده‌ها</strong></td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">دائمی است مگر اینکه reset یا revert شود.</td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">موقت است مگر اینکه اعمال یا pop شود.</td>
            <td style=""padding: 10px; border: 1px solid #ddd;"">تغییرات دائمی هستند و در هر دو شاخه باقی می‌مانند.</td>
        </tr>
    </tbody>
</table>


<h4>به زبان ساده</h4>
<p>Git stash مانند یک قفسه موقت برای تغییرات شما است. شما تغییراتتان را در قفسه می‌گذارید (stash)، سپس به شاخه دیگری می‌روید، و زمانی که آماده‌اید، به قفسه برمی‌گردید و ادامه می‌دهید.</p>

<h4>اشتباهات رایج</h4>
<ul>
    <li>فراموش کردن اعمال یا pop کردن stash ها که باعث از دست رفتن کارها می‌شود.</li>
    <li>استفاده از stash برای فایل‌های untracked بدون تنظیم گزینه‌های صحیح.</li>
    <li>ذخیره فایل‌های بزرگ یا غیرضروری بدون پاک‌سازی آنها بعداً.</li>
</ul>

<h2>بهترین شیوه‌ها</h2>
<ul>
    <li>از پیام‌های توصیفی هنگام ذخیره تغییرات با stash استفاده کنید تا دلیل ذخیره‌سازی مشخص باشد.</li>
    <li>به‌طور منظم stash‌های غیرضروری را پاک کنید تا لیست stash شما تمیز بماند.</li>
    <li>فقط زمانی که مطمئن هستید فایل‌های untracked اهمیت دارند، آنها را stash کنید.</li>
    <li>برای کنترل دقیق‌تر روی تغییرات، از گزینه `--patch` استفاده کنید تا بتوانید به‌طور تعاملی تغییرات را ذخیره کنید.</li>
    <li>قبل از pop کردن یک stash، اطمینان حاصل کنید که working directory شما تمیز است و تغییرات متناقضی وجود ندارد.</li>
</ul>

<h2>محدودیت‌ها</h2>
<ul>
    <li>تغییرات stash موقت هستند و ممکن است از بین بروند اگر apply یا pop نشوند.</li>
    <li>Git stash فایل‌های untracked یا ignored را شامل نمی‌شود مگر اینکه با گزینه‌های مناسب مشخص شوند.</li>
    <li>اعمال stash ممکن است باعث بروز conflict شود که نیاز به رفع دستی دارد.</li>
</ul>

<h3>نحوه استفاده</h3>
<p>Git stash ابزار ساده‌ای برای ذخیره موقت تغییرات است. فقط کافی است از دستور `git stash` برای ذخیره تغییرات استفاده کنید. با دستور `git stash list` می‌توانید لیست همه stash‌ها را مشاهده کنید. برای اعمال یا حذف یک stash از `git stash apply` یا `git stash pop` استفاده کنید.</p>

<h2>نمای کلی</h2>
<p>Git stash ابزاری قدرتمند برای توسعه‌دهندگانی است که نیاز دارند تغییرات خود را به‌طور موقت ذخیره کرده و از commit کردن آنها جلوگیری کنند. چه بخواهید شاخه‌ها را تغییر دهید یا تغییرات جدیدی را از مخزن pull کنید، `git stash` به شما کمک می‌کند تا working directory خود را تمیز نگه‌دارید و کارهای نیمه‌تمام خود را برای بعد ذخیره کنید.</p>

<h4>گزینه‌ها</h4>
<ul>
    <li>-u, --include-untracked : شامل فایل‌های untracked</li>
    <li>-a, --all : شامل همه فایل‌ها حتی ignored</li>
    <li>save &lt;message&gt; : ذخیره با پیام دلخواه</li>
    <li>apply [stash] : اعمال یک stash</li>
    <li>pop [stash] : اعمال و حذف یک stash</li>
    <li>list : لیست stash‌ها</li>
    <li>drop &lt;stash&gt; : حذف یک stash مشخص</li>
    <li>clear : حذف همه stash‌ها</li>
    <li>-k, --keep-index : حفظ staged changes</li>
    <li>--patch : ذخیره تعاملی per hunk</li>
</ul>";

    public List<GitField> Fields { get; set; } = new List<GitField>
    {
        new GitField{ Name="IncludeUntracked", LabelEn="Include Untracked (-u)", LabelFa="شامل فایل‌های Untracked (-u)", Type="checkbox" },
        new GitField{ Name="All", LabelEn="Include All (-a)", LabelFa="شامل همه فایل‌ها (-a)", Type="checkbox" },
        new GitField{ Name="Message", LabelEn="Message", LabelFa="پیام", Type="text", PlaceholderEn="WIP: changes", PlaceholderFa="WIP: تغییرات" },
        new GitField{ Name="KeepIndex", LabelEn="Keep Index (-k)", LabelFa="حفظ staged changes (-k)", Type="checkbox" },
        new GitField{ Name="Patch", LabelEn="Interactive Patch (--patch)", LabelFa="ذخیره تعاملی (--patch)", Type="checkbox" },
        new GitField{ Name="StashCommand", LabelEn="Command", LabelFa="دستور", Type="select", Options=new List<GitOption>
            {
                new GitOption{ Value="save", TextEn="Save", TextFa="ذخیره" },
                new GitOption{ Value="apply", TextEn="Apply", TextFa="اعمال" },
                new GitOption{ Value="pop", TextEn="Pop", TextFa="اعمال و حذف" },
                new GitOption{ Value="list", TextEn="List", TextFa="لیست" },
                new GitOption{ Value="drop", TextEn="Drop", TextFa="حذف" },
                new GitOption{ Value="clear", TextEn="Clear", TextFa="پاک کردن" }
            }
        },
        new GitField{ Name="StashIndex", LabelEn="Stash Index (e.g., stash@{1})", LabelFa="شماره stash (مثال: stash@{1})", Type="text" }
    };
}
