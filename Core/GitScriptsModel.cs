namespace Core;

public class GitScriptsModel
    {
        public string TitleEn => "Ultimate Git Scripts Collection";
        public string TitleFa => "مجموعه نهایی اسکریپت‌های Git";

        public List<GitTab> Tabs { get; set; } = new List<GitTab>
        {
            new GitTab
            {
                Id = "commits-branches",
                TitleEn = "Commits & Branches",
                TitleFa = "Commit و Branch",
                ContentEn = @"
<h3>Auto Commit with Timestamp</h3>
<pre>
#!/bin/bash
FILES_CHANGED=$(git status --porcelain | wc -l)
git add .
git commit -m ""[AUTO] Update $(date +'%Y-%m-%d %H:%M:%S') - $FILES_CHANGED files changed""
git push
</pre>

<h3>Create Feature Branch from Develop</h3>
<pre>
#!/bin/bash
BRANCH=$1
git checkout develop
git pull origin develop
git checkout -b feature/$BRANCH
echo ""Feature branch feature/$BRANCH created from develop""
</pre>

<h3>Delete Local Merged Branches</h3>
<pre>
#!/bin/bash
git fetch -p
git branch --merged | grep -v ""\*"" | grep -v main | grep -v develop | xargs -n 1 git branch -d
</pre>

<h3>List Branches with Last Commit</h3>
<pre>
#!/bin/bash
git for-each-ref --sort=-committerdate refs/heads/ --format='%(refname:short) %(committerdate:relative) %(authorname)'
</pre>

<h3>Interactive Rebase Script</h3>
<pre>
#!/bin/bash
BASE=$1
git fetch origin
git rebase -i $BASE
</pre>
",
                ContentFa = @"
<h3>Commit خودکار با Timestamp</h3>
<pre>
#!/bin/bash
FILES_CHANGED=$(git status --porcelain | wc -l)
git add .
git commit -m ""[AUTO] Update $(date +'%Y-%m-%d %H:%M:%S') - $FILES_CHANGED files changed""
git push
</pre>

<h3>ایجاد Feature Branch از Develop</h3>
<pre>
#!/bin/bash
BRANCH=$1
git checkout develop
git pull origin develop
git checkout -b feature/$BRANCH
echo ""Feature branch feature/$BRANCH created from develop""
</pre>

<h3>حذف Branchهای Merge شده محلی</h3>
<pre>
#!/bin/bash
git fetch -p
git branch --merged | grep -v ""\*"" | grep -v main | grep -v develop | xargs -n 1 git branch -d
</pre>

<h3>لیست Branchها با آخرین Commit</h3>
<pre>
#!/bin/bash
git for-each-ref --sort=-committerdate refs/heads/ --format='%(refname:short) %(committerdate:relative) %(authorname)'
</pre>

<h3>Rebase تعاملی</h3>
<pre>
#!/bin/bash
BASE=$1
git fetch origin
git rebase -i $BASE
</pre>"
            },

            new GitTab
            {
                Id = "release-tag",
                TitleEn = "Release & Tag",
                TitleFa = "Release و Tag",
                ContentEn = @"
<h3>Automated Tagging</h3>
<pre>
#!/bin/bash
VERSION=$1
BRANCH=${2:-main}
git checkout $BRANCH
git pull origin $BRANCH
git tag -a ""v$VERSION"" -m ""Release version $VERSION""
git push origin ""v$VERSION""
</pre>

<h3>Release with Tests & Build</h3>
<pre>
#!/bin/bash
BRANCH=${1:-main}
git checkout $BRANCH
git pull origin $BRANCH
npm run lint
npm test
read -p ""Tests passed? Continue release? (y/n): "" confirm
if [[ $confirm == ""y"" ]]; then
    ./build.sh
    git tag -a ""v$(date +'%Y.%m.%d.%H%M')"" -m ""Automated release""
    git push origin $BRANCH --tags
fi
</pre>

<h3>Delete Remote Tag</h3>
<pre>
#!/bin/bash
TAG=$1
git tag -d $TAG
git push origin :refs/tags/$TAG
</pre>
",
                ContentFa = @"
<h3>Tag خودکار</h3>
<pre>
#!/bin/bash
VERSION=$1
BRANCH=${2:-main}
git checkout $BRANCH
git pull origin $BRANCH
git tag -a ""v$VERSION"" -m ""Release version $VERSION""
git push origin ""v$VERSION""
</pre>

<h3>Release با Test و Build</h3>
<pre>
#!/bin/bash
BRANCH=${1:-main}
git checkout $BRANCH
git pull origin $BRANCH
npm run lint
npm test
read -p ""Tests passed? Continue release? (y/n): "" confirm
if [[ $confirm == ""y"" ]]; then
    ./build.sh
    git tag -a ""v$(date +'%Y.%m.%d.%H%M')"" -m ""Automated release""
    git push origin $BRANCH --tags
fi
</pre>

<h3>حذف Tag از Remote</h3>
<pre>
#!/bin/bash
TAG=$1
git tag -d $TAG
git push origin :refs/tags/$TAG
</pre>"
            },

            new GitTab
            {
                Id = "maintenance",
                TitleEn = "Maintenance & Optimization",
                TitleFa = "نگهداری و بهینه‌سازی",
                ContentEn = @"
<h3>Clean Dangling Objects</h3>
<pre>
#!/bin/bash
git fsck --full
git prune
git gc --aggressive --prune=now
</pre>

<h3>Find Large Files</h3>
<pre>
#!/bin/bash
git rev-list --objects --all |
git cat-file --batch-check='%(objecttype) %(objectname) %(objectsize) %(rest)' |
sort -n -k3 |
tail -n 20
</pre>

<h3>Reflog Cleanup</h3>
<pre>
#!/bin/bash
git reflog expire --expire=now --all
git gc --prune=now
</pre>

<h3>Repository Size Summary</h3>
<pre>
#!/bin/bash
git count-objects -vH
</pre>
",
                ContentFa = @"
<h3>پاکسازی Objectهای dangling</h3>
<pre>
#!/bin/bash
git fsck --full
git prune
git gc --aggressive --prune=now
</pre>

<h3>یافتن فایل‌های بزرگ</h3>
<pre>
#!/bin/bash
git rev-list --objects --all |
git cat-file --batch-check='%(objecttype) %(objectname) %(objectsize) %(rest)' |
sort -n -k3 |
tail -n 20
</pre>

<h3>پاکسازی Reflog</h3>
<pre>
#!/bin/bash
git reflog expire --expire=now --all
git gc --prune=now
</pre>

<h3>خلاصه اندازه Repository</h3>
<pre>
#!/bin/bash
git count-objects -vH
</pre>"
            },

            new GitTab
            {
                Id = "workflow",
                TitleEn = "Team Workflow Scripts",
                TitleFa = "Workflow تیمی",
                ContentEn = @"
<h3>Sync Fork with Upstream</h3>
<pre>
#!/bin/bash
git fetch upstream
git checkout main
git merge upstream/main
git push origin main
</pre>

<h3>Pre-push Hook</h3>
<pre>
#!/bin/bash
echo ""Running lint, test, and security checks...""
npm run lint && npm test && npm run security-check
if [ $? -ne 0 ]; then
    echo ""Push aborted: Lint/Test/Security failed""
    exit 1
fi
</pre>

<h3>Commit Message Enforcement</h3>
<pre>
#!/bin/bash
pattern=""^(feat|fix|docs|style|refactor|test|chore|perf)\(.*\): .+""
if ! grep -qE ""$pattern"" ""$1""; then
    echo ""Invalid commit message format!""
    exit 1
fi
</pre>
",
                ContentFa = @"
<h3>همگام‌سازی Fork با Upstream</h3>
<pre>
#!/bin/bash
git fetch upstream
git checkout main
git merge upstream/main
git push origin main
</pre>

<h3>Pre-push Hook حرفه‌ای</h3>
<pre>
#!/bin/bash
echo ""Running lint, test, and security checks...""
npm run lint && npm test && npm run security-check
if [ $? -ne 0 ]; then
    echo ""Push aborted: Lint/Test/Security failed""
    exit 1
fi
</pre>

<h3>قوانین Commit Message</h3>
<pre>
#!/bin/bash
pattern=""^(feat|fix|docs|style|refactor|test|chore|perf)\(.*\): .+""
if ! grep -qE ""$pattern"" ""$1""; then
    echo ""Invalid commit message format!""
    exit 1
fi
</pre>"
            },

            new GitTab
            {
                Id = "lfs",
                TitleEn = "Git LFS Scripts",
                TitleFa = "Git LFS و فایل‌های بزرگ",
                ContentEn = @"
<h3>Track Large Files</h3>
<pre>
#!/bin/bash
git lfs install
git lfs track ""*.zip"" ""*.mp4"" ""*.mov""
git add .gitattributes
git commit -m ""Track large files with Git LFS""
git push
</pre>

<h3>Pull LFS Safely</h3>
<pre>
#!/bin/bash
git lfs fetch --all
git lfs checkout
</pre>

<h3>Clean Unused LFS Objects</h3>
<pre>
#!/bin/bash
git lfs prune
</pre>
",
                ContentFa = @"
<h3>ردیابی فایل‌های بزرگ با LFS</h3>
<pre>
#!/bin/bash
git lfs install
git lfs track ""*.zip"" ""*.mp4"" ""*.mov""
git add .gitattributes
git commit -m ""Track large files with Git LFS""
git push
</pre>

<h3>Pull امن فایل‌های LFS</h3>
<pre>
#!/bin/bash
git lfs fetch --all
git lfs checkout
</pre>

<h3>پاکسازی فایل‌های LFS بلااستفاده</h3>
<pre>
#!/bin/bash
git lfs prune
</pre>"
            },

            new GitTab
            {
                Id = "reporting",
                TitleEn = "Reporting & Analysis",
                TitleFa = "گزارش‌گیری و تحلیل",
                ContentEn = @"
<h3>Daily Commits Report</h3>
<pre>
#!/bin/bash
git log --since=midnight --pretty=format:""%h %an %s""
</pre>

<h3>Largest Files in Repo</h3>
<pre>
#!/bin/bash
git rev-list --objects --all |
git cat-file --batch-check='%(objecttype) %(objectname) %(objectsize) %(rest)' |
sed -n 's/^blob //p' |
sort -n -k2 |
tail -n 50
</pre>

<h3>Inactive Branch Report</h3>
<pre>
#!/bin/bash
git for-each-ref --format='%(refname:short) %(committerdate:relative)' refs/heads/ | sort -k2
</pre>

<h3>Contribution Stats</h3>
<pre>
#!/bin/bash
git shortlog -sne
</pre>
",
                ContentFa = @"
<h3>گزارش Commitهای روزانه</h3>
<pre>
#!/bin/bash
git log --since=midnight --pretty=format:""%h %an %s""
</pre>

<h3>بزرگترین فایل‌های repo</h3>
<pre>
#!/bin/bash
git rev-list --objects --all |
git cat-file --batch-check='%(objecttype) %(objectname) %(objectsize) %(rest)' |
sed -n 's/^blob //p' |
sort -n -k2 |
tail -n 50
</pre>

<h3>گزارش branchهای inactive</h3>
<pre>
#!/bin/bash
git for-each-ref --format='%(refname:short) %(committerdate:relative)' refs/heads/ | sort -k2
</pre>

<h3>آمار Contribution</h3>
<pre>
#!/bin/bash
git shortlog -sne
</pre>"
            },

            new GitTab
            {
                Id = "automation",
                TitleEn = "Automation Scripts",
                TitleFa = "اتوماسیون و اسکریپت‌ها",
                ContentEn = @"
<h3>Pre-merge Sanity Check</h3>
<pre>
#!/bin/bash
BRANCH=$1
git fetch origin $BRANCH
git checkout $BRANCH
npm run lint && npm test
if [ $? -ne 0 ]; then
    echo ""Merge blocked due to failed tests/lint""
    exit 1
fi
</pre>

<h3>Auto Rebase Before Push</h3>
<pre>
#!/bin/bash
BRANCH=$(git symbolic-ref --short HEAD)
git fetch origin
git rebase origin/main
if [ $? -ne 0 ]; then
    echo ""Rebase conflicts detected! Resolve manually.""
    exit 1
fi
git push origin $BRANCH
</pre>

<h3>Auto Merge Development into Feature Branch</h3>
<pre>
#!/bin/bash
FEATURE=$1
git checkout $FEATURE
git pull origin $FEATURE
git merge develop
git push origin $FEATURE
</pre>
",
                ContentFa = @"
<h3>Pre-merge Sanity Check</h3>
<pre>
#!/bin/bash
BRANCH=$1
git fetch origin $BRANCH
git checkout $BRANCH
npm run lint && npm test
if [ $? -ne 0 ]; then
    echo ""Merge blocked due to failed tests/lint""
    exit 1
fi
</pre>

<h3>Rebase خودکار قبل از Push</h3>
<pre>
#!/bin/bash
BRANCH=$(git symbolic-ref --short HEAD)
git fetch origin
git rebase origin/main
if [ $? -ne 0 ]; then
    echo ""Rebase conflicts detected! Resolve manually.""
    exit 1
fi
git push origin $BRANCH
</pre>

<h3>Merge خودکار Development به Feature Branch</h3>
<pre>
#!/bin/bash
FEATURE=$1
git checkout $FEATURE
git pull origin $FEATURE
git merge develop
git push origin $FEATURE
</pre>"
            }
        };
    }

