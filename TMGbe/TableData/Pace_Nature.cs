using TMGbe.Models;

public class PaceNature
{
    public List<ColumnBase> getTableColumnData()
    { 
        Column<Component, String> nameColumn = new Column<Component, string>
            ("component", "Component", "color: #6c757d;" );
        Column<Component, String> nameColumnWrapper = new Column<Component, string>
            (null, "", null, null, childrenColumns: new List<ColumnBase>() { nameColumn });
        Column<Component, long> filesColumn = new Column<Component, long>
            ("#files", "#", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, long> filesColumnWrapper = new Column<Component, long>
            ("files", "files", "font-weight: 400;font-size: 13px;color: #6c757d;", null, childrenColumns: new List<ColumnBase>() { filesColumn });
        Column<Component, int> linesColumn = new Column<Component, int>
            ("x1000", "x1000", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> linesColumnWrapper = new Column<Component, int>
            ("lines", "lines", "font-weight: 400;font-size: 13px;color: #6c757d;", null, childrenColumns: new List<ColumnBase>() { linesColumn });
        Column<Component, int> commitsColumn = new Column<Component, int>
            ("#commits", "#", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> commitsColumnWrapper = new Column<Component, int>
            ("commits", "commits", "font-weight: 400;font-size: 13px;color: #6c757d;", null, childrenColumns: new List<ColumnBase>() { commitsColumn });
        Column<Component, DateTime> startDateColumn = new Column<Component, DateTime>
            ("yyyy-mmstart", "yyyy-mm", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> startDateColumnWrapper = new Column<Component, int>
            ("startDate", "start date", "font-weight: 400;font-size: 13px;color: #6c757d;", null, childrenColumns: new List<ColumnBase>() { startDateColumn });
        Column<Component, DateTime> latestDateColumn = new Column<Component, DateTime>
            ("yyyy-mmlatest", "yyyy-mm", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> latestDateColumnWrapper = new Column<Component, int>
            ("latestDate", "latest date", "font-weight: 400;font-size: 13px;color: #6c757d;", null, childrenColumns: new List<ColumnBase>() { latestDateColumn });
        Column<Component, int> firstHeaderColumn = new Column<Component, int>
        (null, "", null, null, childrenColumns: new List<ColumnBase>()
        {
            nameColumnWrapper, filesColumnWrapper, linesColumnWrapper, commitsColumnWrapper, startDateColumnWrapper,
            latestDateColumnWrapper
        });
        
        

        Column<Component, int> medianCommitsColumn = new Column<Component, int>
            ("mediancommits", "median", "font-weight: 400;font-size: 13px;color: #6c757d;", conditionalFormatter:
                (component, i) =>
                {
                    i = 30;
                    if (i > 10)
                    {
                        return new Dictionary<string, string>()
                        {
                            { "color" , "yellow;" }
                        };
                    }
                    else
                    {
                        return new Dictionary<string, string>()
                        {
                            {  "color" , "red;" }
                        };
                    }
                });
        Column<Component, int> medianCommitsColumnWrapper = new Column<Component, int>
            (null, "commits", "font-weight: 400;font-size: 13px;color: #6c757d;", null, childrenColumns: new List<ColumnBase>() { medianCommitsColumn });
        Column<Component, int> medianRecentCommitsColumnOne = new Column<Component, int>
            ("medianrecentcommits", "median", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> medianRecentCommitsColumnTwo = new Column<Component, int>
            ("trendrecentcommits", "trend", "font-weight: 400;font-size: 13px;color: #6c757d;",borderR:true, sortable:false);
        Column<Component, int> medianRecentCommitsColumnWrapper = new Column<Component, int>
        (null, "recent" + "<br>" + "commits", "font-weight: 400;font-size: 13px;color: #6c757d;", null,borderR:true,
            childrenColumns: new List<ColumnBase>() { medianRecentCommitsColumnOne, medianRecentCommitsColumnTwo });
        Column<Component, int> secondHeaderColumn = new Column<Component, int>
        (null, "Commits" + "<br>" + "per month", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>() { medianCommitsColumnWrapper, medianRecentCommitsColumnWrapper });

        
        
        
        Column<Component, int> medianChumColumn = new Column<Component, int>
            ("medianchum", "x1000", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> medianChumColumnWrapper = new Column<Component, int>
        ("medianchumwrapper", "chum" + "<br>" + "median", "font-weight: 400;font-size: 13px;color: #6c757d;", null,
            childrenColumns: new List<ColumnBase>() { medianChumColumn });
        Column<Component, int> recentMedianChumColumnOne = new Column<Component, int>
            ("recentmedianchum", "x1000", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> recentMedianChumColumnTwo = new Column<Component, int>
            ("recentmedianchumtrend", "trend", "font-weight: 400;font-size: 13px;color: #6c757d;",borderR:true, sortable:false);
        Column<Component, int> recentMedianChumColumnWrapper = new Column<Component, int>
        (null, "recent chum" + "<br>" + "median", "font-weight: 400;font-size: 13px;color: #6c757d;", null,borderR:true,
            childrenColumns: new List<ColumnBase>() { recentMedianChumColumnOne, recentMedianChumColumnTwo });
        Column<Component, int> thirdHeaderColumn = new Column<Component, int>
        (null, "Change Volume" + "<br>" + "per month", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>() { medianChumColumnWrapper, recentMedianChumColumnWrapper });

        
        
        
        Column<Component, int> medianGrowthColumn = new Column<Component, int>
            ("mediangrowth", "x100", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> medianGrowthColumnWrapper = new Column<Component, int>
        ("mediangrowthwrapper", "lines" + "<br>" + "median", "font-weight: 400;font-size: 13px;color: #6c757d;", null,
            childrenColumns: new List<ColumnBase>() { medianGrowthColumn });
        Column<Component, int> recentMedianGrowthColumnOne = new Column<Component, int>
            ("recentmediangrowth", "x1000", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> recentMedianGrowthColumnTwo = new Column<Component, int>
            ("recentmediangrowthtrend", "trend", "font-weight: 400;font-size: 13px;color: #6c757d;",borderR:true, sortable:false);
        Column<Component, int> recentMedianGrowthColumnWrapper = new Column<Component, int>
        (null, "recent lines" + "<br>" + "median", "font-weight: 400;font-size: 13px;color: #6c757d;", null,borderR:true,
            childrenColumns: new List<ColumnBase>() { recentMedianGrowthColumnOne, recentMedianGrowthColumnTwo });
        Column<Component, int> fourthHeaderColumn = new Column<Component, int>
        (null, "Growth" + "<br>" + "per month", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>() { medianGrowthColumnWrapper, recentMedianGrowthColumnWrapper });

        Column<Component, int> medianFilesColumn = new Column<Component, int>
            ("medianfiles", "median", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> medianFilesColumnWrapper = new Column<Component, int>
            ("medianfileswrapper", "files", "font-weight: 400;font-size: 13px;color: #6c757d;", null, childrenColumns: new List<ColumnBase>() { medianFilesColumn });
        Column<Component, int> recentMedianFilesColumnOne = new Column<Component, int>
            ("recentmedianfiles", "median", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> recentMedianFilesColumnTwo = new Column<Component, int>
            ("recentmedianfilestrend", "trend", "font-weight: 400;font-size: 13px;color: #6c757d;",borderR:true, sortable:false);
        Column<Component, int> recentMedianFilesColumnWrapper = new Column<Component, int>
        (null, "recent" + "<br>" + "files", "font-weight: 400;font-size: 13px;color: #6c757d;", null,borderR:true,
            childrenColumns: new List<ColumnBase>() { recentMedianFilesColumnOne, recentMedianFilesColumnTwo });
        Column<Component, int> fifthHeaderColumn = new Column<Component, int>
        (null, "Active Files" + "<br>" + "per month", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>() { medianFilesColumnWrapper, recentMedianFilesColumnWrapper });

        Column<Component, int> medianDevsColumn = new Column<Component, int>
            ("mediandevs", "median", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> medianDevsColumnWrapper = new Column<Component, int>
        ("mediandevswrapper", "all" + "<br>" + "devs", "font-weight: 400;font-size: 13px;color: #6c757d;", null,
            childrenColumns: new List<ColumnBase>() { medianDevsColumn });
        Column<Component, int> recentMedianDevsColumnOne = new Column<Component, int>
            ("recentmediandevs", "median", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> recentMedianDevsColumnTwo = new Column<Component, int>
            ("recentmediandevstrend", "trend", "font-weight: 400;font-size: 13px;color: #6c757d;",borderR:true, sortable:false);
        Column<Component, int> recentMedianDevsColumnWrapper = new Column<Component, int>
        (null, "recent" + "<br>" + "devs", "font-weight: 400;font-size: 13px;color: #6c757d;", null,borderR:true,
            childrenColumns: new List<ColumnBase>() { recentMedianDevsColumnOne, recentMedianDevsColumnTwo });
        Column<Component, int> sixthHeaderColumn = new Column<Component, int>
        (null, "Developers" + "<br>" + "per month", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>() { medianDevsColumnWrapper, recentMedianDevsColumnWrapper });

        Column<Component, int> medianTasksColumn = new Column<Component, int>
            ("mediantasks", "median", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> medianTasksColumnWrapper = new Column<Component, int>
        ("mediantaskswrapper", "all" + "<br>" + "tasks", "font-weight: 400;font-size: 13px;color: #6c757d;", null,
            childrenColumns: new List<ColumnBase>() { medianTasksColumn });
        Column<Component, int> recentMedianTasksColumnOne = new Column<Component, int>
            ("recentmediantasks", "median", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> recentMedianTasksColumnTwo = new Column<Component, int>
            ("recentmediantaskstrend", "trend", "font-weight: 400;font-size: 13px;color: #6c757d;",borderR:true, sortable:false);
        Column<Component, int> recentMedianTasksColumnWrapper = new Column<Component, int>
        (null, "recent" + "<br>" + "tasks", "font-weight: 400;font-size: 13px;color: #6c757d;", null,borderR:true,
            childrenColumns: new List<ColumnBase>() { recentMedianTasksColumnOne, recentMedianTasksColumnTwo });
        Column<Component, int> seventhHeaderColumn = new Column<Component, int>(null,
            "Active Tasks" + "<br>" + "per month", null, null,borderR:true,
        childrenColumns: new List<ColumnBase>() { medianTasksColumnWrapper, recentMedianTasksColumnWrapper });
        
        Column<Component, int> medianDaysColumn = new Column<Component, int>
            ("mediandays", "median", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> medianDaysColumnWrapper = new Column<Component, int>
        ("mediandayswrapper", "active" + "<br>" + "days", "font-weight: 400;font-size: 13px;color: #6c757d;", null,
            childrenColumns: new List<ColumnBase>() { medianDaysColumn });
        Column<Component, int> recentMedianDaysColumnOne = new Column<Component, int>
            ("recentmediandays", "median", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> recentMedianDaysColumnTwo = new Column<Component, int>
            ("recentmediandaystrend", "trend", "font-weight: 400;font-size: 13px;color: #6c757d;",borderR:true, sortable:false);
        Column<Component, int> recentMedianDaysColumnWrapper = new Column<Component, int>
        (null, "recent" + "<br>" + "active days", "font-weight: 400;font-size: 13px;color: #6c757d;", null,borderR:true,
            childrenColumns: new List<ColumnBase>() { recentMedianDaysColumnOne, recentMedianDaysColumnTwo });
        Column<Component, int> eightHeaderColumn = new Column<Component, int>
        (null, "Commit Days" + "<br>" + "per month", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>() { medianDaysColumnWrapper, recentMedianDaysColumnWrapper });

        
        
        
        
        
        
        
        Column<Component, int> allChangesCreationalColumn = new Column<Component, int>
            ("allchangescreational", "%", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> allChangesCreationalColumnWrapper = new Column<Component, int>
        (null, "all" + "<br>" + "changes", "font-weight: 400;font-size: 13px;color: #6c757d;", null,
            childrenColumns: new List<ColumnBase>() { allChangesCreationalColumn });
        Column<Component, int> recentChangesCreationalColumnOne = new Column<Component, int>
            ("recentchangescreational%", "%", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> recentChangesCreationalColumnTwo = new Column<Component, int>
            ("recentchangescreationaltrend", "trend", "font-weight: 400;font-size: 13px;color: #6c757d;",borderR:true, sortable:false);
        Column<Component, int> recentChangesCreationalColumnWrapper = new Column<Component, int>
        (null, "recent" + "<br>" + "changes", "font-weight: 400;font-size: 13px;color: #6c757d;", null,borderR:true,
            childrenColumns: new List<ColumnBase>()
                { recentChangesCreationalColumnOne, recentChangesCreationalColumnTwo });
        Column<Component, int> ninethHeaderColumn = new Column<Component, int>
        (null, "Creational", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>()
                { allChangesCreationalColumnWrapper, recentChangesCreationalColumnWrapper },
            description: "changes by which" + "<br>" + " files are added to repo", descriptionStyle:"font-weight: 400;font-size: 13px;color: gray");

        
        Column<Component, int> allChangesDevColumn = new Column<Component, int>
            ("allchangesdev", "%", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> allChangesDevColumnWrapper = new Column<Component, int>
        (null, "all" + "<br>" + "changes", "font-weight: 400;font-size: 13px;color: #6c757d;", null,
            childrenColumns: new List<ColumnBase>() { allChangesDevColumn });
        Column<Component, int> recentChangesDevColumnOne = new Column<Component, int>
            ("recentchangesdev%", "%", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> recentChangesDevColumnTwo = new Column<Component, int>
            ("recentchangesdevtrend", "trend", "font-weight: 400;font-size: 13px;color: #6c757d;",borderR:true, sortable:false);
        Column<Component, int> recentChangesDevColumnWrapper = new Column<Component, int>
        (null, "recent" + "<br>" + "changes", "font-weight: 400;font-size: 13px;color: #6c757d;", null,borderR:true,
            childrenColumns: new List<ColumnBase>() { recentChangesDevColumnOne, recentChangesDevColumnTwo });
        Column<Component, int> tenthHeaderColumn = new Column<Component, int>
        (null, "Development", null, null,borderR:true, childrenColumns: new List<ColumnBase>()
        {
            allChangesDevColumnWrapper, recentChangesDevColumnWrapper
        }, description: "changes causing " + "<br>" + "substantial growth", descriptionStyle:"font-weight: 400;font-size: 13px;color: gray");

        Column<Component, int> allChangesRefColumn = new Column<Component, int>
            ("allchangesref", "%", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> allChangesRefColumnWrapper = new Column<Component, int>
        (null, "all" + "<br>" + "changes", "font-weight: 400;font-size: 13px;color: #6c757d;", null,
            childrenColumns: new List<ColumnBase>() { allChangesRefColumn });
        Column<Component, int> recentChangesRefColumnOne = new Column<Component, int>
            ("recentchangesref%", "%", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> recentChangesRefColumnTwo = new Column<Component, int>
            ("recentchangesreftrend", "trend", "font-weight: 400;font-size: 13px;color: #6c757d;", sortable:false);
        Column<Component, int> recentChangesRefColumnWrapper = new Column<Component, int>
        (null, "recent" + "<br>" + "changes", "font-weight: 400;font-size: 13px;color: #6c757d;", null,
            childrenColumns: new List<ColumnBase>() { recentChangesRefColumnOne, recentChangesRefColumnTwo });
        Column<Component, int> eleventhHeaderColumn = new Column<Component, int>
        (null, "Refinement", null, null, childrenColumns: new List<ColumnBase>()
        {
            allChangesRefColumnWrapper, recentChangesRefColumnWrapper
        }, description: "changes causing " + "<br>" + "small churn", descriptionStyle:"font-weight: 400;font-size: 13px;color: gray");

        Column<Component, int> highestLevelHeaderOne = new Column<Component, int>
            (null, "", null, null, childrenColumns: new List<ColumnBase>() { firstHeaderColumn });
        Column<Component, int> highestLevelHeaderTwo = new Column<Component, int>
        (null, "PACE of CHANGES", "color: #6c757d;", null,borderR:true,childrenColumns: new List<ColumnBase>()
        {
            secondHeaderColumn, thirdHeaderColumn, fourthHeaderColumn, fifthHeaderColumn, sixthHeaderColumn,
            seventhHeaderColumn, eightHeaderColumn
        });
        Column<Component, int> highestLevelHeaderThree = new Column<Component, int>
        (null, "NATURE of Changes", "color: #6c757d;", null,
            childrenColumns: new List<ColumnBase>() { ninethHeaderColumn, tenthHeaderColumn, eleventhHeaderColumn });
        
        return new List<ColumnBase>() { highestLevelHeaderOne, highestLevelHeaderTwo, highestLevelHeaderThree };
    }
}