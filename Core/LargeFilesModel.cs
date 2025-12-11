namespace Core
{
    public class LargeFilesModel
        {
            public string TitleEn => "Working with Large Files";
            public string TitleFa => "کار با فایل‌های بزرگ";

            public string GuideHtmlEn => @"
<h2>Overview</h2>
<p>Git is not designed for large binary files. For such files, use <strong>Git LFS (Large File Storage)</strong> to manage them efficiently without bloating your repository.</p>

<h3>When to Use Git LFS</h3>
<ul>
<li>Files larger than 50MB</li>
<li>Binaries that change frequently (images, audio, video, datasets)</li>
<li>Build artifacts or dependencies</li>
</ul>

<h3>Setup</h3>
<pre>
// Install Git LFS (one-time)
git lfs install

// Track file types
git lfs track ""*.psd""

// Verify tracked patterns
git lfs track
</pre>

<h3>Adding and Committing LFS Files</h3>
<pre>
git add .gitattributes
git add assets/largefile.psd
git commit -m ""Add large PSD file""
git push origin main
</pre>

<h3>Common Mistakes</h3>
<ul>
<li>Not installing Git LFS before cloning</li>
<li>Tracking individual files instead of patterns</li>
<li>Committing large binaries directly without LFS</li>
<li>Ignoring <code>.gitattributes</code> changes</li>
<li>Pushing very large files exceeding platform limits</li>
</ul>

<h3>Best Practices</h3>
<ul>
<li>Track file types, not individual files</li>
<li>Commit <code>.gitattributes</code> to share tracking with the team</li>
<li>Do not store frequently changing binaries in normal Git history</li>
<li>Use shallow clone or sparse checkout for huge repositories</li>
<li>Prune old LFS objects periodically (<code>git lfs prune</code>)</li>
</ul>

<h3>Advanced Techniques</h3>
<ul>
<li>Retroactively convert files in history: <code>git lfs migrate</code></li>
<li>Lock files for collaborative editing: <code>git lfs lock</code></li>
<li>Integrate with CI/CD to fetch LFS assets only when needed</li>
</ul>
";

            public string GuideHtmlFa => @"
<h2>نمای کلی</h2>
<p>گیت برای فایل‌های باینری بزرگ طراحی نشده است. برای چنین فایل‌هایی از <strong>Git LFS (Large File Storage)</strong> استفاده کنید تا مخزن شما بزرگ نشود و کارآمد باقی بماند.</p>

<h3>چه زمانی Git LFS استفاده کنیم</h3>
<ul>
<li>فایل‌های بزرگتر از 50MB</li>
<li>فایل‌های باینری که اغلب تغییر می‌کنند (تصاویر، صوت، ویدئو، دیتاست‌ها)</li>
<li>آرتیفکت‌های build یا وابستگی‌های بزرگ</li>
</ul>

<h3>راه‌اندازی</h3>
<pre>
// Install Git LFS (one-time)
git lfs install

// Track file types
git lfs track ""*.psd""

// Verify tracked patterns
git lfs track
</pre>

<h3>اضافه کردن و کامیت فایل‌ها</h3>
<pre>
git add .gitattributes
git add assets/largefile.psd
git commit -m ""Add large PSD file""
git push origin main
</pre>

<h3>اشتباهات رایج</h3>
<ul>
<li>نصب نکردن Git LFS قبل از کلون</li>
<li>ردیابی فایل‌های منفرد به جای نوع فایل</li>
<li>کامیت مستقیم فایل‌های بزرگ بدون LFS</li>
<li>نادیده گرفتن تغییرات <code>.gitattributes</code></li>
<li>Push کردن فایل‌های خیلی بزرگ و رد شدن توسط پلتفرم</li>
</ul>

<h3>بهترین شیوه‌ها</h3>
<ul>
<li>نوع فایل را ردیابی کنید، نه فایل‌های منفرد</li>
<li>فایل <code>.gitattributes</code> را commit کنید تا تیم شما به درستی ردیابی کند</li>
<li>فایل‌های باینری که زیاد تغییر می‌کنند را در تاریخچهٔ معمولی ذخیره نکنید</li>
<li>برای مخزن‌های بزرگ از shallow clone یا sparse checkout استفاده کنید</li>
<li>به‌طور دوره‌ای اشیاء قدیمی را پاک کنید: <code>git lfs prune</code></li>
</ul>

<h3>تکنیک‌های پیشرفته</h3>
<ul>
<li>تبدیل فایل‌های بزرگ موجود در تاریخچه: <code>git lfs migrate</code></li>
<li>قفل کردن فایل‌ها برای ویرایش گروهی: <code>git lfs lock</code></li>
<li>ادغام با CI/CD برای pull فقط در صورت نیاز</li>
</ul>
";

            public List<GitField> Fields { get; set; } = new List<GitField>
        {
            new GitField { Name="Files", LabelEn="Files or Patterns", LabelFa="فایل‌ها یا الگوها", Type="text", PlaceholderEn="*.psd *.zip", PlaceholderFa="مثال: *.psd *.zip", IsRequired=true },
            new GitField { Name="Track", LabelEn="Track with LFS", LabelFa="ردیابی با LFS", Type="checkbox" },
            new GitField { Name="Lock", LabelEn="Lock file after adding", LabelFa="قفل کردن فایل پس از اضافه کردن", Type="checkbox" },
            new GitField { Name="DryRun", LabelEn="Dry Run (-n)", LabelFa="شبیه‌سازی (-n)", Type="checkbox" }
        };
        }
    

}
