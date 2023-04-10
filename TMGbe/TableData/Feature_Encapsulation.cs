using TMGbe.Models;

public class Feature_Encapsulation
{
    public List<ColumnBase> getFeatureEncapsulationTableData()
    {
        Column<Component, String> nameColumn =
            new Column<Component, string>("component", null, "Component", null);
        Column<Component, String> nameColumnWrapper =
            new Column<Component, string>(null, null, "", null, new List<ColumnBase>() { nameColumn });
        Column<Component, long> filesColumn =
            new Column<Component, long>("#files", null, "#", null);
        Column<Component, long> filesColumnWrapper =
            new Column<Component, long>("files", null, "all"+"<br>"+"files", null, new List<ColumnBase>() { filesColumn });
        Column<Component, long> sourcefilesColumn =
            new Column<Component, long>("#sourcefiles", null, "#", null);
        Column<Component, long> sourcefilesColumnWrapper =
            new Column<Component, long>("sourcefiles", null, "source"+"<br>"+"files", null, new List<ColumnBase>() { sourcefilesColumn });
        Column<Component, int> linesColumn = new Column<Component, int>("x1000lines", null, "x1000", null);
        Column<Component, int> linesColumnWrapper = new Column<Component, int>("alllines", null,
            "all" + "<br>" + "lines", null, new List<ColumnBase>() { linesColumn });
        Column<Component, int> sourcelinesColumn = new Column<Component, int>("x1000sourcelines", null, "x1000", null);
        Column<Component, int> sourcelinesColumnWrapper = new Column<Component, int>("sourcelines", null,
            "source" + "<br>" + "lines", null, new List<ColumnBase>() { sourcelinesColumn });
        Column<Component, int> commitsColumn = new Column<Component, int>("#commits", null, "#", null);
        Column<Component, int> commitsColumnWrapper = new Column<Component, int>("commits", null, "commits", null,
            new List<ColumnBase>() { commitsColumn });
        Column<Component, int> startDateColumn = new Column<Component, int>("yyyy-mmstart", null, "yyyy-mm", null);
        Column<Component, int> startDateColumnWrapper = new Column<Component, int>("startDate", null, "start date",
            null, new List<ColumnBase>() { startDateColumn });
        Column<Component, int> latestDateColumn = new Column<Component, int>("yyyy-mmlatest", null, "yyyy-mm", null);
        Column<Component, int> latestDateColumnWrapper = new Column<Component, int>("latestDate", null, "latest date",
            null, new List<ColumnBase>() { latestDateColumn });
        Column<Component, int> firstHeaderColumn = new Column<Component, int>(null, null, "", null,
            new List<ColumnBase>()
            {
                nameColumnWrapper, filesColumnWrapper,sourcefilesColumnWrapper, linesColumnWrapper, sourcelinesColumnWrapper,commitsColumnWrapper, startDateColumnWrapper,
                latestDateColumnWrapper
            });
        
        Column<Component, int> allWideCommitsColumn = new Column<Component, int>("allwidecommits", null, "%", null);
        Column<Component, int> allWideCommitsColumnWrapper = new Column<Component, int>(null, null, "all"+"<br>"+"commits", null,
            new List<ColumnBase>() { allWideCommitsColumn });
        Column<Component, int> wideRecentCommitsColumnOne =
            new Column<Component, int>("widerecentcommits%", null, "%", null);
        Column<Component, int> wideRecentCommitsColumnTwo =
            new Column<Component, int>("widetrendrecentcommits", null, "trend", null);
        Column<Component, int> wideRecentCommitsColumnWrapper = new Column<Component, int>(null, null,
            "recent" + "<br>" + "commits", null,
            new List<ColumnBase>() { wideRecentCommitsColumnOne, wideRecentCommitsColumnTwo });
        Column<Component, int> secondHeaderColumn = new Column<Component, int>(null, null,
            "Wide Commits", null,
            new List<ColumnBase>() { allWideCommitsColumnWrapper, wideRecentCommitsColumnWrapper }/*, description:"commits with"+"<br>"+"many files"*/);

        Column<Component, int> allDeepCommitsColumn = new Column<Component, int>("alldeepcommits", null, "%", null);
        Column<Component, int> allDeepCommitsColumnWrapper = new Column<Component, int>(null, null, "all"+"<br>"+"commits", null,
            new List<ColumnBase>() { allDeepCommitsColumn });
        Column<Component, int> deepRecentCommitsColumnOne =
            new Column<Component, int>("deeprecentcommits%", null, "%", null);
        Column<Component, int> deepRecentCommitsColumnTwo =
            new Column<Component, int>("deep%alldrecentcommits", null, "%all", null);
        Column<Component, int> deepRecentCommitsColumnWrapper = new Column<Component, int>(null, null,
            "recent" + "<br>" + "commits", null,
            new List<ColumnBase>() { deepRecentCommitsColumnOne, deepRecentCommitsColumnTwo });
        Column<Component, int> thirdHeaderColumn = new Column<Component, int>(null, null,
            "Deep Commits", null,
            new List<ColumnBase>() { allDeepCommitsColumnWrapper, deepRecentCommitsColumnWrapper }/*, description:"commits with"+"<br>"+"high chum"*/);

        Column<Component, int> allHighTasksColumn = new Column<Component, int>("#hightasks", null, "#", null);
        Column<Component, int> allHighTasksColumnWrapper = new Column<Component, int>(null, null, "tasks", null,
            new List<ColumnBase>() { allHighTasksColumn });
        Column<Component, int> highRecentTasksColumnOne =
            new Column<Component, int>("highrecenttasks#", null, "#", null);
        Column<Component, int> highRecentTasksColumnTwo =
            new Column<Component, int>("high%alldrecenttasks", null, "%all", null);
        Column<Component, int> highRecentTasksColumnWrapper = new Column<Component, int>(null, null,
            "recent" + "<br>" + "tasks", null,
            new List<ColumnBase>() { highRecentTasksColumnOne, highRecentTasksColumnTwo });
        Column<Component, int> fourthHeaderColumn = new Column<Component, int>(null, null,
            "High-Impact Tasks", null,
            new List<ColumnBase>() { allHighTasksColumnWrapper, highRecentTasksColumnWrapper }/*, description:"tasks that appear in changes"+"<br>"+"of many files"*/);

        Column<Component, int> allScatteredTasksColumn = new Column<Component, int>("#scatteredtasks", null, "#", null);
        Column<Component, int> allScatteredTasksColumnWrapper = new Column<Component, int>(null, null, "tasks", null,
            new List<ColumnBase>() { allScatteredTasksColumn });
        Column<Component, int> scatteredRecentTasksColumnOne =
            new Column<Component, int>("scatteredrecenttasks#", null, "#", null);
        Column<Component, int> scatteredRecentTasksColumnTwo =
            new Column<Component, int>("scattered%alldrecenttasks", null, "%all", null);
        Column<Component, int> scatteredRecentTasksColumnWrapper = new Column<Component, int>(null, null,
            "recent" + "<br>" + "tasks", null,
            new List<ColumnBase>() { scatteredRecentTasksColumnOne, scatteredRecentTasksColumnTwo });
        Column<Component, int> fifthHeaderColumn = new Column<Component, int>(null, null,
            "Scattered Tasks", null,
            new List<ColumnBase>() { allScatteredTasksColumnWrapper, scatteredRecentTasksColumnWrapper }/*, description:"tasks associated with"+"<br>"+"changes in many areas"*/);

        Column<Component, int> duplicatedFilesColumnOne =
            new Column<Component, int>("duplicatedfiles#", null, "#", null);
        Column<Component, int> duplicatedFilesColumnTwo =
            new Column<Component, int>("duplicatedfiles%src", null, "%src", null);
        Column<Component, int> duplicatedFilesColumnWrapper = new Column<Component, int>(null, null,
            "duplicated" + "<br>" + "files", null,
            new List<ColumnBase>() { duplicatedFilesColumnOne, duplicatedFilesColumnTwo });
        Column<Component, int> linesFilesDuplicationColumnOne =
            new Column<Component, int>("linesfilesduplication#", null, "#", null);
        Column<Component, int>linesFilesDuplicationColumnTwo =
            new Column<Component, int>("linesfilesduplication%src", null, "%src", null);
        Column<Component, int> linesFilesDuplicationColumnWrapper = new Column<Component, int>(null, null,
            "lines of files" + "<br>" + "with duplication", null,
            new List<ColumnBase>() { linesFilesDuplicationColumnOne, linesFilesDuplicationColumnTwo });
        Column<Component, int> activeRecentlyColumnOne =
            new Column<Component, int>("activerecently#", null, "#", null);
        Column<Component, int>activeRecentlyColumnTwo =
            new Column<Component, int>("activerecently%dup", null, "%dup", null);
        Column<Component, int>activeRecentlyColumnWrapper = new Column<Component, int>(null, null,
            "active" + "<br>" + "recently", null,
            new List<ColumnBase>() { activeRecentlyColumnOne, activeRecentlyColumnTwo });
        Column<Component, int> createdRecentlyColumnOne =
            new Column<Component, int>("createdrecently#", null, "#", null);
        Column<Component, int>createdRecentlyColumnTwo =
            new Column<Component, int>("createdrecently%dup", null, "%dup", null);
        Column<Component, int>createdRecentlyColumnWrapper = new Column<Component, int>(null, null,
            "created" + "<br>" + "recently", null,
            new List<ColumnBase>() { createdRecentlyColumnOne, createdRecentlyColumnTwo });
        Column<Component, int> sixthHeaderColumn = new Column<Component, int>(null, null,
            "Duplicated Code", null,
            new List<ColumnBase>() { duplicatedFilesColumnWrapper, linesFilesDuplicationColumnWrapper,activeRecentlyColumnWrapper, createdRecentlyColumnWrapper}/*, description:"source-files with "+"<br>"+"code duplication"*/);
        return new List<ColumnBase>() { firstHeaderColumn,secondHeaderColumn,thirdHeaderColumn,fourthHeaderColumn,fifthHeaderColumn,sixthHeaderColumn };
    }
}