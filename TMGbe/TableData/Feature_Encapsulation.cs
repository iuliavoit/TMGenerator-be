using TMGbe.Models;

public class Feature_Encapsulation
{
    public List<ColumnBase> getTableColumnData()
    {
        Column<Component, String> nameColumn = new Column<Component, string>
            ("component", "Component", null);
        Column<Component, String> nameColumnWrapper = new Column<Component, string>
            (null, "", null, null, childrenColumns: new List<ColumnBase>() { nameColumn });
        Column<Component, long> filesColumn = new Column<Component, long>
            ("#files", "#", null);
        Column<Component, long> filesColumnWrapper = new Column<Component, long>
            ("files", "all" + "<br>" + "files", null, null, childrenColumns: new List<ColumnBase>() { filesColumn });
        Column<Component, long> sourcefilesColumn = new Column<Component, long>
            ("#sourcefiles", "#", null);
        Column<Component, long> sourcefilesColumnWrapper = new Column<Component, long>
        ("sourcefiles", "source" + "<br>" + "files", null, null,
            childrenColumns: new List<ColumnBase>() { sourcefilesColumn });
        Column<Component, int> linesColumn = new Column<Component, int>
            ("x1000lines", "x1000", null);
        Column<Component, int> linesColumnWrapper = new Column<Component, int>
            ("alllines", "all" + "<br>" + "lines", null, null, childrenColumns: new List<ColumnBase>() { linesColumn });
        Column<Component, int> sourcelinesColumn = new Column<Component, int>
            ("x1000sourcelines", "x1000", null);
        Column<Component, int> sourcelinesColumnWrapper = new Column<Component, int>
        ("sourcelines", "source" + "<br>" + "lines", null, null,
            childrenColumns: new List<ColumnBase>() { sourcelinesColumn });
        Column<Component, int> commitsColumn = new Column<Component, int>
            ("#commits", "#", null);
        Column<Component, int> commitsColumnWrapper = new Column<Component, int>
            ("commits", "commits", null, null, childrenColumns: new List<ColumnBase>() { commitsColumn });
        Column<Component, DateTime> startDateColumn = new Column<Component, DateTime>
            ("yyyy-mmstart", "yyyy-mm", null);
        Column<Component, DateTime> startDateColumnWrapper = new Column<Component, DateTime>
            ("startDate", "start date", null, null, childrenColumns: new List<ColumnBase>() { startDateColumn });
        Column<Component, DateTime> latestDateColumn = new Column<Component, DateTime>
            ("yyyy-mmlatest", "yyyy-mm", null, null);
        Column<Component, int> latestDateColumnWrapper = new Column<Component, int>
            ("latestDate", "latest date", null, null, childrenColumns: new List<ColumnBase>() { latestDateColumn });
        Column<Component, int> firstHeaderColumn = new Column<Component, int>(null, "", null, null,
            childrenColumns: new List<ColumnBase>()
            {
                nameColumnWrapper, filesColumnWrapper, sourcefilesColumnWrapper, linesColumnWrapper,
                sourcelinesColumnWrapper, commitsColumnWrapper, startDateColumnWrapper,
                latestDateColumnWrapper
            });

        Column<Component, int> allWideCommitsColumn = new Column<Component, int>
            ("allwidecommits", "%", null);
        Column<Component, int> allWideCommitsColumnWrapper = new Column<Component, int>
        (null, "all" + "<br>" + "commits", null, null,
            childrenColumns: new List<ColumnBase>() { allWideCommitsColumn });
        Column<Component, int> wideRecentCommitsColumnOne = new Column<Component, int>
            ("widerecentcommits%", "%", null);
        Column<Component, int> wideRecentCommitsColumnTwo = new Column<Component, int>
            ("widetrendrecentcommits", "trend", null,borderR:true);
        Column<Component, int> wideRecentCommitsColumnWrapper = new Column<Component, int>
        (null, "recent" + "<br>" + "commits", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>() { wideRecentCommitsColumnOne, wideRecentCommitsColumnTwo });
        Column<Component, int> secondHeaderColumn = new Column<Component, int>(null, "Wide Commits", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>()
            {
                allWideCommitsColumnWrapper, wideRecentCommitsColumnWrapper
            }, description: "commits with" + "<br>" + "many files");

        Column<Component, int> allDeepCommitsColumn = new Column<Component, int>
            ("alldeepcommits", "%", null);
        Column<Component, int> allDeepCommitsColumnWrapper = new Column<Component, int>
        (null, "all" + "<br>" + "commits", null, null,
            childrenColumns: new List<ColumnBase>() { allDeepCommitsColumn });
        Column<Component, int> deepRecentCommitsColumnOne = new Column<Component, int>
            ("deeprecentcommits%", "%", null);
        Column<Component, int> deepRecentCommitsColumnTwo = new Column<Component, int>
            ("deep%alldrecentcommits", "%all", null,borderR:true);
        Column<Component, int> deepRecentCommitsColumnWrapper = new Column<Component, int>
        (null, "recent" + "<br>" + "commits", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>() { deepRecentCommitsColumnOne, deepRecentCommitsColumnTwo });
        Column<Component, int> thirdHeaderColumn = new Column<Component, int>(null, "Deep Commits", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>()
            {
                allDeepCommitsColumnWrapper, deepRecentCommitsColumnWrapper
            }, description: "commits with" + "<br>" + "high chum");

        Column<Component, int> allHighTasksColumn = new Column<Component, int>
            ("#hightasks", "#", null);
        Column<Component, int> allHighTasksColumnWrapper = new Column<Component, int>
            (null, "tasks", null, null, childrenColumns: new List<ColumnBase>() { allHighTasksColumn });
        Column<Component, int> highRecentTasksColumnOne = new Column<Component, int>
            ("highrecenttasks#", "#", null);
        Column<Component, int> highRecentTasksColumnTwo = new Column<Component, int>
            ("high%alldrecenttasks", "%all", null,borderR:true);
        Column<Component, int> highRecentTasksColumnWrapper = new Column<Component, int>
        (null, "recent" + "<br>" + "tasks", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>() { highRecentTasksColumnOne, highRecentTasksColumnTwo });
        Column<Component, int> fourthHeaderColumn = new Column<Component, int>
        (null, "High-Impact Tasks", null, null,borderR:true, childrenColumns: new List<ColumnBase>()
        {
            allHighTasksColumnWrapper, highRecentTasksColumnWrapper
        }, description: "tasks that appear in changes" + "<br>" + "of many files");

        Column<Component, int> allScatteredTasksColumn = new Column<Component, int>
            ("#scatteredtasks", "#", null);
        Column<Component, int> allScatteredTasksColumnWrapper = new Column<Component, int>
            (null, "tasks", null, null, childrenColumns: new List<ColumnBase>() { allScatteredTasksColumn });
        Column<Component, int> scatteredRecentTasksColumnOne = new Column<Component, int>
            ("scatteredrecenttasks#", "#", null);
        Column<Component, int> scatteredRecentTasksColumnTwo = new Column<Component, int>
            ("scattered%alldrecenttasks", "%all", null,borderR:true);
        Column<Component, int> scatteredRecentTasksColumnWrapper = new Column<Component, int>
        (null, "recent" + "<br>" + "tasks", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>() { scatteredRecentTasksColumnOne, scatteredRecentTasksColumnTwo });
        Column<Component, int> fifthHeaderColumn = new Column<Component, int>
        (null, "Scattered Tasks", null, null, borderR:true,childrenColumns: new List<ColumnBase>()
        {
            allScatteredTasksColumnWrapper, scatteredRecentTasksColumnWrapper
        }, description: "tasks associated with" + "<br>" + "changes in many areas");

        Column<Component, int> duplicatedFilesColumnOne = new Column<Component, int>
            ("duplicatedfiles#", "#", null);
        Column<Component, int> duplicatedFilesColumnTwo = new Column<Component, int>
            ("duplicatedfiles%src", "%src", null);
        Column<Component, int> duplicatedFilesColumnWrapper = new Column<Component, int>
        (null, "duplicated" + "<br>" + "files", null, null,
            childrenColumns: new List<ColumnBase>() { duplicatedFilesColumnOne, duplicatedFilesColumnTwo });
        Column<Component, int> linesFilesDuplicationColumnOne = new Column<Component, int>
            ("linesfilesduplication#", "#", null);
        Column<Component, int> linesFilesDuplicationColumnTwo = new Column<Component, int>
            ("linesfilesduplication%src", "%src", null);
        Column<Component, int> linesFilesDuplicationColumnWrapper = new Column<Component, int>
        (null, "lines of files" + "<br>" + "with duplication", null, null,
            childrenColumns: new List<ColumnBase>() { linesFilesDuplicationColumnOne, linesFilesDuplicationColumnTwo });
        Column<Component, int> activeRecentlyColumnOne = new Column<Component, int>
            ("activerecently#", "#", null);
        Column<Component, int> activeRecentlyColumnTwo = new Column<Component, int>
            ("activerecently%dup", "%dup", null);
        Column<Component, int> activeRecentlyColumnWrapper = new Column<Component, int>
        (null, "active" + "<br>" + "recently", null, null,
            childrenColumns: new List<ColumnBase>() { activeRecentlyColumnOne, activeRecentlyColumnTwo });
        Column<Component, int> createdRecentlyColumnOne = new Column<Component, int>
            ("createdrecently#", "#", null);
        Column<Component, int> createdRecentlyColumnTwo = new Column<Component, int>
            ("createdrecently%dup", "%dup", null);
        Column<Component, int> createdRecentlyColumnWrapper = new Column<Component, int>
        (null, "created" + "<br>" + "recently", null, null,
            childrenColumns: new List<ColumnBase>() { createdRecentlyColumnOne, createdRecentlyColumnTwo });
        Column<Component, int> sixthHeaderColumn = new Column<Component, int>
        (null, "Duplicated Code", null, null, childrenColumns: new List<ColumnBase>()
        {
            duplicatedFilesColumnWrapper, linesFilesDuplicationColumnWrapper, activeRecentlyColumnWrapper,
            createdRecentlyColumnWrapper
        }, description: "source-files with " + "<br>" + "code duplication");
        return new List<ColumnBase>()
        {
            firstHeaderColumn, secondHeaderColumn, thirdHeaderColumn, fourthHeaderColumn, fifthHeaderColumn,
            sixthHeaderColumn
        };
    }
}