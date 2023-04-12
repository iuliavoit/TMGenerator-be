using TMGbe.Models;

public class Feature_Traceability
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
            ("files", "files", null, null, childrenColumns: new List<ColumnBase>() { filesColumn });
        Column<Component, int> linesColumn = new Column<Component, int>
            ("x1000", "x1000", null);
        Column<Component, int> linesColumnWrapper = new Column<Component, int>
            ("lines", "lines", null, null, childrenColumns: new List<ColumnBase>() { linesColumn });
        Column<Component, int> commitsColumn = new Column<Component, int>
            ("#commits", "#", null);
        Column<Component, int> commitsColumnWrapper = new Column<Component, int>
            ("commits", "commits", null, null, childrenColumns: new List<ColumnBase>() { commitsColumn });
        Column<Component, DateTime> startDateColumn = new Column<Component, DateTime>
            ("yyyy-mmstart", "yyyy-mm", null);
        Column<Component, int> startDateColumnWrapper = new Column<Component, int>
            ("startDate", "start date", null, null, childrenColumns: new List<ColumnBase>() { startDateColumn });
        Column<Component, DateTime> latestDateColumn = new Column<Component, DateTime>
            ("yyyy-mmlatest", "yyyy-mm", null);
        Column<Component, int> latestDateColumnWrapper = new Column<Component, int>
            ("latestDate", "latest date", null, null, childrenColumns: new List<ColumnBase>() { latestDateColumn });
        Column<Component, int> firstHeaderColumn = new Column<Component, int>
        (null, "", null, null,
            childrenColumns: new List<ColumnBase>()
            {
                nameColumnWrapper, filesColumnWrapper, linesColumnWrapper, commitsColumnWrapper, startDateColumnWrapper,
                latestDateColumnWrapper
            });

        Column<Component, int> allSmartCommitsColumn = new Column<Component, int>
            ("%allcommitssmart", "%", null, null);
        Column<Component, int> allSmartCommitsColumnWrapper = new Column<Component, int>
        ("allcommitssmart", "all" + "<br>" + "commits", null, null,
            childrenColumns: new List<ColumnBase>() { allSmartCommitsColumn });
        Column<Component, int> recentSmartCommitsColumn = new Column<Component, int>
            ("%recentcommitssmart", "%", null, null, sortable: false);
        Column<Component, int> trendRecentSmartCommitsColumn = new Column<Component, int>
            ("trendrecentcommitssmart", "trend", null, null, sortable: false, borderR: true);
        Column<Component, int> recentSmartCommitsColumnWrapper = new Column<Component, int>
        ("recentcommitssmart", "recent" + "<br>" + "commits", null, null,
            childrenColumns: new List<ColumnBase>() { recentSmartCommitsColumn, trendRecentSmartCommitsColumn },
            borderR: true);
        Column<Component, int> secondHeaderColumn = new Column<Component, int>
        ("smartCommits", "Smart Commits", null, null,
            childrenColumns: new List<ColumnBase>() { allSmartCommitsColumnWrapper, recentSmartCommitsColumnWrapper },
            description: "commits with <br> task references", borderL: true, borderR: true);

        Column<Component, int> allLiterateCommitsColumn = new Column<Component, int>
            ("%allcommitsliterate", "%", null);
        Column<Component, int> allLiterateCommitsColumnWrapper = new Column<Component, int>
        ("allcommitsliterate", "all" + "<br>" + "commits", null, null,
            childrenColumns: new List<ColumnBase>() { allLiterateCommitsColumn });
        Column<Component, int> recentLiterateCommitsColumn = new Column<Component, int>
            ("%recentcommitsliterate", "%", null, null, sortable: false);
        Column<Component, int> trendRecentLiterateCommitsColumn = new Column<Component, int>
            ("trendrecentcommitsliterate", "trend", null, null, sortable: false);
        Column<Component, int> recentLiterateCommitsColumnWrapper = new Column<Component, int>
        ("recentcommitsliterate", "recent" + "<br>" + "commits", null, null,
            childrenColumns: new List<ColumnBase>() { recentLiterateCommitsColumn, trendRecentLiterateCommitsColumn });
        Column<Component, int> thirdHeaderColumn = new Column<Component, int>
        (null, "Literate Commits", null, null,
            childrenColumns: new List<ColumnBase>()
                { allLiterateCommitsColumnWrapper, recentLiterateCommitsColumnWrapper },
            description: "commits with <br> reasonable message");
        return new List<ColumnBase>() { firstHeaderColumn, secondHeaderColumn, thirdHeaderColumn };
    }
}