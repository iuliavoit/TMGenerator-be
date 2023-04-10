using TMGbe.Models;

public class PaceNature
{
    public List<ColumnBase> getPaceNatureTableColumnData()
    {
        Column<Component, String> nameColumn =
            new Column<Component, string>("component", null, "Component", null);
        Column<Component, String> nameColumnWrapper =
            new Column<Component, string>(null, null, "", null, new List<ColumnBase>() { nameColumn });
        Column<Component, long> filesColumn =
            new Column<Component, long>("#files", null, "#", null);
        Column<Component, long> filesColumnWrapper =
            new Column<Component, long>("files", null, "files", null, new List<ColumnBase>() { filesColumn });
        Column<Component, int> linesColumn = new Column<Component, int>("x1000", null, "x1000", null);
        Column<Component, int> linesColumnWrapper =
            new Column<Component, int>("lines", null, "lines", null, new List<ColumnBase>() { linesColumn });
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
                nameColumnWrapper, filesColumnWrapper, linesColumnWrapper, commitsColumnWrapper, startDateColumnWrapper,
                latestDateColumnWrapper
            });

        Column<Component, int> medianCommitsColumn = new Column<Component, int>("mediancommits", null, "median", null);
        Column<Component, int> medianCommitsColumnWrapper = new Column<Component, int>(null, null, "commits", null,
            new List<ColumnBase>() { medianCommitsColumn });
        Column<Component, int> medianRecentCommitsColumnOne =
            new Column<Component, int>("medianrecentcommits", null, "median", null);
        Column<Component, int> medianRecentCommitsColumnTwo =
            new Column<Component, int>("trendrecentcommits", null, "trend", null);
        Column<Component, int> medianRecentCommitsColumnWrapper = new Column<Component, int>(null, null,
            "recent" + "<br>" + "commits", null,
            new List<ColumnBase>() { medianRecentCommitsColumnOne, medianRecentCommitsColumnTwo });
        Column<Component, int> secondHeaderColumn = new Column<Component, int>(null, null,
            "Commits" + "<br>" + "per month", null,
            new List<ColumnBase>() { medianCommitsColumnWrapper, medianRecentCommitsColumnWrapper });

        Column<Component, int> medianChumColumn = new Column<Component, int>("medianchum", null, "x1000", null);
        Column<Component, int> medianChumColumnWrapper = new Column<Component, int>("medianchumwrapper", null,
            "chum" + "<br>" + "median", null, new List<ColumnBase>() { medianChumColumn });
        Column<Component, int> recentMedianChumColumnOne =
            new Column<Component, int>("recentmedianchum", null, "x1000", null);
        Column<Component, int> recentMedianChumColumnTwo =
            new Column<Component, int>("recentmedianchumtrend", null, "trend", null);
        Column<Component, int> recentMedianChumColumnWrapper = new Column<Component, int>(null, null,
            "recent chum" + "<br>" + "median", null,
            new List<ColumnBase>() { recentMedianChumColumnOne, recentMedianChumColumnTwo });
        Column<Component, int> thirdHeaderColumn = new Column<Component, int>(null, null,
            "Change Volume" + "<br>" + "per month", null,
            new List<ColumnBase>() { medianChumColumnWrapper, recentMedianChumColumnWrapper });
        
        Column<Component, int> medianGrowthColumn = new Column<Component, int>("mediangrowth", null, "x100", null);
        Column<Component, int> medianGrowthColumnWrapper = new Column<Component, int>("mediangrowthwrapper", null,
            "lines" + "<br>" + "median", null, new List<ColumnBase>() { medianGrowthColumn });
        Column<Component, int> recentMedianGrowthColumnOne =
            new Column<Component, int>("recentmediangrowth", null, "x1000", null);
        Column<Component, int> recentMedianGrowthColumnTwo =
            new Column<Component, int>("recentmediangrowthtrend", null, "trend", null);
        Column<Component, int> recentMedianGrowthColumnWrapper = new Column<Component, int>(null, null,
            "recent lines" + "<br>" + "median", null,
            new List<ColumnBase>() { recentMedianGrowthColumnOne, recentMedianGrowthColumnTwo });
        Column<Component, int> fourthHeaderColumn = new Column<Component, int>(null, null,
            "Growth" + "<br>" + "per month", null,
            new List<ColumnBase>() { medianGrowthColumnWrapper, recentMedianGrowthColumnWrapper });
        
        
        Column<Component, int> medianFilesColumn = new Column<Component, int>("medianfiles", null, "median", null);
        Column<Component, int> medianFilesColumnWrapper = new Column<Component, int>("medianfileswrapper", null,
            "files", null, new List<ColumnBase>() { medianFilesColumn });
        Column<Component, int> recentMedianFilesColumnOne =
            new Column<Component, int>("recentmedianfiles", null, "median", null);
        Column<Component, int> recentMedianFilesColumnTwo =
            new Column<Component, int>("recentmedianfilestrend", null, "trend", null);
        Column<Component, int> recentMedianFilesColumnWrapper = new Column<Component, int>(null, null,
            "recent" + "<br>" + "files", null,
            new List<ColumnBase>() { recentMedianFilesColumnOne, recentMedianFilesColumnTwo });
        Column<Component, int> fifthHeaderColumn = new Column<Component, int>(null, null,
            "Active Files" + "<br>" + "per month", null,
            new List<ColumnBase>() { medianFilesColumnWrapper, recentMedianFilesColumnWrapper });
        
        Column<Component, int> medianDevsColumn = new Column<Component, int>("mediandevs", null, "median", null);
        Column<Component, int> medianDevsColumnWrapper = new Column<Component, int>("mediandevswrapper", null,
            "all"+"<br>"+"devs", null, new List<ColumnBase>() { medianDevsColumn });
        Column<Component, int> recentMedianDevsColumnOne =
            new Column<Component, int>("recentmediandevs", null, "median", null);
        Column<Component, int> recentMedianDevsColumnTwo =
            new Column<Component, int>("recentmediandevstrend", null, "trend", null);
        Column<Component, int> recentMedianDevsColumnWrapper = new Column<Component, int>(null, null,
            "recent" + "<br>" + "devs", null,
            new List<ColumnBase>() { recentMedianDevsColumnOne, recentMedianDevsColumnTwo });
        Column<Component, int> sixthHeaderColumn = new Column<Component, int>(null, null,
            "Developers" + "<br>" + "per month", null,
            new List<ColumnBase>() { medianDevsColumnWrapper, recentMedianDevsColumnWrapper });
        
        
        Column<Component, int> medianTasksColumn = new Column<Component, int>("mediantasks", null, "median", null);
        Column<Component, int> medianTasksColumnWrapper = new Column<Component, int>("mediantaskswrapper", null,
            "all"+"<br>"+"tasks", null, new List<ColumnBase>() { medianTasksColumn });
        Column<Component, int> recentMedianTasksColumnOne =
            new Column<Component, int>("recentmediantasks", null, "median", null);
        Column<Component, int> recentMedianTasksColumnTwo =
            new Column<Component, int>("recentmediantaskstrend", null, "trend", null);
        Column<Component, int> recentMedianTasksColumnWrapper = new Column<Component, int>(null, null,
            "recent" + "<br>" + "tasks", null,
            new List<ColumnBase>() { recentMedianTasksColumnOne, recentMedianTasksColumnTwo });
        Column<Component, int> seventhHeaderColumn = new Column<Component, int>(null, null,
            "Active Tasks" + "<br>" + "per month", null,
            new List<ColumnBase>() { medianTasksColumnWrapper, recentMedianTasksColumnWrapper });
        
        Column<Component, int> medianDaysColumn = new Column<Component, int>("mediandays", null, "median", null);
        Column<Component, int> medianDaysColumnWrapper = new Column<Component, int>("mediandayswrapper", null,
            "active"+"<br>"+"days", null, new List<ColumnBase>() { medianDaysColumn });
        Column<Component, int> recentMedianDaysColumnOne =
            new Column<Component, int>("recentmediandays", null, "median", null);
        Column<Component, int> recentMedianDaysColumnTwo =
            new Column<Component, int>("recentmediandaystrend", null, "trend", null);
        Column<Component, int> recentMedianDaysColumnWrapper = new Column<Component, int>(null, null,
            "recent" + "<br>" + "active days", null,
            new List<ColumnBase>() { recentMedianDaysColumnOne, recentMedianDaysColumnTwo });
        Column<Component, int> eightHeaderColumn = new Column<Component, int>(null, null,
            "Active Tasks" + "<br>" + "per month", null,
            new List<ColumnBase>() { medianDaysColumnWrapper, recentMedianDaysColumnWrapper });
        

        Column<Component, int> allChangesCreationalColumn =
            new Column<Component, int>("allchangescreational", null, "%", null);
        Column<Component, int> allChangesCreationalColumnWrapper =
            new Column<Component, int>(null, null, "all" + "<br>" + "changes", null,
                new List<ColumnBase>() { allChangesCreationalColumn });
        Column<Component, int> recentChangesCreationalColumnOne =
            new Column<Component, int>("recentchangescreational%", null, "%", null);
        Column<Component, int> recentChangesCreationalColumnTwo =
            new Column<Component, int>("recentchangescreationaltrend", null, "trend", null);
        Column<Component, int> recentChangesCreationalColumnWrapper =
            new Column<Component, int>(null, null, "recent" + "<br>" + "changes", null,
                new List<ColumnBase>() { recentChangesCreationalColumnOne, recentChangesCreationalColumnTwo });
        Column<Component, int> ninethHeaderColumn = new Column<Component, int>(null, null,
            "Creational" , null,
            new List<ColumnBase>() { allChangesCreationalColumnWrapper, recentChangesCreationalColumnWrapper }, description:"changes by which"+"<br>"+" files are added to repo");
        
        Column<Component, int> allChangesDevColumn =
            new Column<Component, int>("allchangesdev", null, "%", null);
        Column<Component, int> allChangesDevColumnWrapper =
            new Column<Component, int>(null, null, "all" + "<br>" + "changes", null,
                new List<ColumnBase>() { allChangesDevColumn });
        Column<Component, int> recentChangesDevColumnOne =
            new Column<Component, int>("recentchangesdev%", null, "%", null);
        Column<Component, int> recentChangesDevColumnTwo =
            new Column<Component, int>("recentchangesdevtrend", null, "trend", null);
        Column<Component, int> recentChangesDevColumnWrapper =
            new Column<Component, int>(null, null, "recent" + "<br>" + "changes", null,
                new List<ColumnBase>() { recentChangesDevColumnOne, recentChangesDevColumnTwo });
        Column<Component, int> tenthHeaderColumn = new Column<Component, int>(null, null,
            "Development" , null,
            new List<ColumnBase>() { allChangesDevColumnWrapper, recentChangesDevColumnWrapper }/*, description:"changes causing "+"<br>"+"substantial growth"*/);

        Column<Component, int> allChangesRefColumn =
            new Column<Component, int>("allchangesref", null, "%", null);
        Column<Component, int> allChangesRefColumnWrapper =
            new Column<Component, int>(null, null, "all" + "<br>" + "changes", null,
                new List<ColumnBase>() { allChangesRefColumn });
        Column<Component, int> recentChangesRefColumnOne =
            new Column<Component, int>("recentchangesref%", null, "%", null);
        Column<Component, int> recentChangesRefColumnTwo =
            new Column<Component, int>("recentchangesreftrend", null, "trend", null);
        Column<Component, int> recentChangesRefColumnWrapper =
            new Column<Component, int>(null, null, "recent" + "<br>" + "changes", null,
                new List<ColumnBase>() { recentChangesRefColumnOne, recentChangesRefColumnTwo });
        Column<Component, int> eleventhHeaderColumn = new Column<Component, int>(null, null,
            "Refinement" , null,
            new List<ColumnBase>() { allChangesRefColumnWrapper, recentChangesRefColumnWrapper }/*, description:"changes causing "+"<br>"+"small churn"*/);

        Column<Component, int> highestLevelHeaderOne = new Column<Component, int>(null, null,
            "", null, new List<ColumnBase>() { firstHeaderColumn });
        Column<Component, int> highestLevelHeaderTwo = new Column<Component, int>(null, null,
            "PACE of CHANGES", null, new List<ColumnBase>() { secondHeaderColumn, thirdHeaderColumn, fourthHeaderColumn,fifthHeaderColumn,sixthHeaderColumn,seventhHeaderColumn, eightHeaderColumn });
        Column<Component, int> highestLevelHeaderThree = new Column<Component, int>(null, null, "NATURE of Changes",
            null, new List<ColumnBase>() { ninethHeaderColumn, tenthHeaderColumn, eleventhHeaderColumn });
        
        return new List<ColumnBase>() { highestLevelHeaderOne, highestLevelHeaderTwo, highestLevelHeaderThree };

    }

}
