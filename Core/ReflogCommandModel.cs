using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Channels;

namespace Core;

public class ReflogCommandModel
{
    public string TitleEn => "Show the Reference Logs";
    public string TitleFa => "نمایش لاگ‌های مرجع";

    public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git reflog [options]</pre>

<h4>Examples</h4>
<pre>
git reflog                # Show the reflog for HEAD
git reflog show <ref>     # Show the reflog for a specific reference
git reflog --date=iso     # Show reflog with ISO format date
</pre>

<h4>What It Does?</h4>
<p>The <strong>git reflog</strong> command allows you to view the history of changes to the references in your Git repository. This includes movements of HEAD, updates to branches, and changes to other references. It is an essential tool for recovering lost commits, finding out what happened to a reference, or debugging.</p>

<h4>Common Use Cases</h4>
<ul>
    <li>Inspecting the history of HEAD and other references.</li>
    <li>Recovering lost commits that are no longer part of the current branch.</li>
    <li>Debugging issues related to branch movements or reset operations.</li>
</ul>

<h4>Best Practices</h4>
<ul>
    <li>Use the <strong>--date</strong> option to specify a date format if you need to sort or filter reflogs by date.</li>
    <li>Always check the reflog when you're unsure about a lost commit, as you may be able to recover it.</li>
    <li>Combine the reflog with commands like <strong>git checkout</strong> or <strong>git reset</strong> to recover previous states of a repository.</li>
</ul>

<h4>Limitations</h4>
<ul>
    <li>Reflogs are stored locally and can be lost if they are not kept for long periods (depending on the configuration).</li>
    <li>Reflogs only track changes to references and do not contain the entire history of changes to the repository.</li>
</ul>

<h4>Common Mistakes</h4>
<ul>
    <li>Not checking the reflog before performing potentially destructive operations, like a hard reset or branch deletion.</li>
    <li>Misinterpreting the output of reflogs, as they can be overwhelming without filtering or searching.</li>
</ul>

<h2>Overview</h2>
<p>The <strong>git reflog</strong> command is an essential tool for tracking the history of references in your Git repository. It allows you to see what happened to HEAD, branches, and other references, even after those commits have been ""lost"" from the current view of the repository. This makes it invaluable for recovering from mistakes or debugging issues with references.</p>

<h2>Comparison with Other Methods</h2>
<table border = '1' cellpadding= '10' cellspacing= '0' style= 'border-collapse: collapse; width: 100%;'>
    <tr style= 'background-color: #f2f2f2;'>
        <th style= 'text-align: left; padding: 8px; font-weight: bold;'> Method </th>
        <th style= 'text-align: left; padding: 8px; font-weight: bold;'> Advantages </th>
        <th style= 'text-align: left; padding: 8px; font-weight: bold;'> Disadvantages </th>
    </tr>
    <tr>
        <td style= 'padding: 8px;'><strong> git reflog</strong></td>
        <td style = 'padding: 8px;'> Tracks the history of reference movements and lost commits. Essential for recovering lost commits.</td>
        <td style = 'padding: 8px;'> Can be lost if not stored for long enough. Only tracks reference changes, not full commit history.</td>
    </tr>
    <tr style = 'background-color: #f9f9f9;'>
        <td style= 'padding: 8px;'><strong> git log</strong></td>
        <td style = 'padding: 8px;'> Shows the full commit history of the current branch, including commit messages and changes.</td>
        <td style = 'padding: 8px;'> Does not track reference changes or ""lost"" commits that are no longer part of the branch.</td>
    </tr>
    <tr>
        <td style = 'padding: 8px;'><strong> git fsck</strong></td>
        <td style = 'padding: 8px;'> Useful for checking repository integrity and recovering unreachable objects (e.g., lost commits).</td>
        <td style = 'padding: 8px;'> Does not provide history of reference changes and is less user-friendly for beginners.</td>
    </tr>
</table>

";

    public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git reflog [گزینه‌ها]</pre>

<h4>مثال‌ها</h4>
<pre>
git reflog                # Show the reflog for HEAD
git reflog show <ref>     # Show the reflog for a specific reference
git reflog --date=iso     # Show reflog with ISO format date
</pre>

<h4>دقیقاً چه می‌کند؟</h4>
<p>دستور <strong>git reflog</strong> به شما این امکان را می‌دهد که تاریخچه تغییرات مربوط به مراجع مختلف در مخزن گیت خود را مشاهده کنید. این تاریخچه شامل حرکت‌های HEAD، به‌روزرسانی‌های شاخه‌ها، و تغییرات دیگر مراجع است. این ابزار برای بازیابی commits گمشده یا بررسی آنچه که برای یک مرجع رخ داده، مفید است.</p>

<h4>موارد کاربرد رایج</h4>
<ul>
    <li>بررسی تاریخچه HEAD و مراجع دیگر.</li>
    <li>بازیابی commits گمشده که دیگر در شاخه جاری وجود ندارند.</li>
    <li>عیب‌یابی مشکلات مربوط به حرکت‌های شاخه یا عملیات reset.</li>
</ul>

<h4>بهترین شیوه‌ها</h4>
<ul>
    <li>از گزینه <strong>--date</strong> برای مشخص کردن فرمت تاریخ استفاده کنید اگر نیاز دارید تا لاگ‌ها را بر اساس تاریخ مرتب یا فیلتر کنید.</li>
    <li>همیشه قبل از انجام عملیات‌های مخرب مانند reset سخت یا حذف شاخه، لاگ‌ها را بررسی کنید.</li>
    <li>ترکیب <strong>git reflog</strong> با دستوراتی مانند <strong>git checkout</strong> یا <strong>git reset</strong> برای بازیابی وضعیت‌های قبلی مخزن.</li>
</ul>

<h4>محدودیت‌ها</h4>
<ul>
    <li>لاگ‌های مرجع به صورت محلی ذخیره می‌شوند و ممکن است در صورت عدم نگهداری برای مدت طولانی از بین بروند (بسته به تنظیمات).</li>
    <li>لاگ‌های مرجع تنها تغییرات مربوط به مراجع را دنبال می‌کنند و تاریخچه کامل تغییرات در مخزن را در بر نمی‌گیرند.</li>
</ul>

<h4>اشتباهات رایج</h4>
<ul>
    <li>عدم بررسی لاگ‌ها قبل از انجام عملیات‌های مخرب مانند reset سخت یا حذف شاخه.</li>
    <li>تفسیر اشتباه خروجی‌های لاگ، زیرا ممکن است بدون فیلتر کردن یا جستجو کردن، بسیار پیچیده به نظر برسند.</li>
</ul>

<h2>نمای کلی</h2>
<p>دستور <strong>git reflog</strong> ابزار ضروری برای پیگیری تاریخچه مراجع در مخزن گیت است. این دستور به شما این امکان را می‌دهد که ببینید چه اتفاقاتی برای HEAD، شاخه‌ها و دیگر مراجع افتاده است، حتی پس از اینکه این commits دیگر در نمای جاری مخزن گم شده‌اند. این ویژگی آن را برای بازیابی از اشتباهات یا عیب‌یابی مشکلات مربوط به مراجع بسیار مفید می‌کند.</p>

<h2>مقایسه با روش‌های دیگر</h2>
<table border='1' cellpadding='10' cellspacing='0' style='border-collapse: collapse; width: 100%;'>
    <tr style='background-color: #f2f2f2;'>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>روش</th>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>مزایا</th>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>معایب</th>
    </tr>
    <tr>
        <td style='padding: 8px;'><strong>git reflog</strong></td>
        <td style='padding: 8px;'>تاریخچه تغییرات مراجع و commits گمشده را پیگیری می‌کند. ابزاری ضروری برای بازیابی commits گمشده.</td>
        <td style='padding: 8px;'>ممکن است در صورت عدم نگهداری مناسب از بین برود. تنها تغییرات مراجع را پیگیری می‌کند و تاریخچه کامل تغییرات را شامل نمی‌شود.</td>
    </tr>
    <tr style='background-color: #f9f9f9;'>
        <td style='padding: 8px;'><strong>git log</strong></td>
        <td style='padding: 8px;'>تاریخچه کامل commits در شاخه جاری، شامل پیام‌ها و تغییرات را نمایش می‌دهد.</td>
        <td style='padding: 8px;'>تغییرات مراجع یا commits گمشده را نشان نمی‌دهد که دیگر بخشی از شاخه جاری نیستند.</td>
    </tr>
    <tr>
        <td style='padding: 8px;'><strong>git fsck</strong></td>
        <td style='padding: 8px;'>برای بررسی یکپارچگی مخزن و بازیابی اشیاء غیرقابل دسترس (مانند commits گمشده) مفید است.</td>
        <td style='padding: 8px;'>تاریخچه تغییرات مراجع را پیگیری نمی‌کند و برای مبتدیان کمتر کاربرپسند است.</td>
    </tr>
</table>

";

    public List<GitField> Fields { get; set; } = new List<GitField>
    {
        new GitField { Name="Ref", LabelEn="Reference", LabelFa="مرجع", Type="text", PlaceholderEn="HEAD", PlaceholderFa="HEAD" },
        new GitField { Name="DateFormat", LabelEn="Date Format (--date)", LabelFa="فرمت تاریخ (--date)", Type="text", PlaceholderEn="iso", PlaceholderFa="iso" },
        new GitField { Name="NoAbbrev", LabelEn="Disable Abbreviation (--no-abbrev)", LabelFa="غیر فعال کردن اختصار (--no-abbrev)", Type="checkbox" }
    };
}
