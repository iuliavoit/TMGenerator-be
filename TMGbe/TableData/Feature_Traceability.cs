using TMGbe.Models;

public class Feature_Traceability
{
    public List<ColumnBase> getFeatureTraceabilityTableColumnData()
    {
        Column<Component, String> nameColumn =
            new Column<Component, string>("component", component => component.Name, "Component", null);
        Column<Component, String> nameColumnWrapper =
            new Column<Component, string>(null, null, "", null, new List<ColumnBase>() { nameColumn });
        Column<Component, long> filesColumn =
            new Column<Component, long>("#files", component => component.files.Count, "#", null);
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

        Column<Component, int> allSmartCommitsColumn = new Column<Component, int>("%allcommitssmart", null, "%", null);
        Column<Component, int> allSmartCommitsColumnWrapper = new Column<Component, int>("allcommitssmart", null,
            "all" + "<br>" + "commits", null, new List<ColumnBase>() { allSmartCommitsColumn });
        Column<Component, int> recentSmartCommitsColumn =
            new Column<Component, int>("%recentcommitssmart", null, "%", null, sortable: false);
        Column<Component, int> trendRecentSmartCommitsColumn =
            new Column<Component, int>("trendrecentcommitssmart", null, "trend", null, sortable: false);
        Column<Component, int> recentSmartCommitsColumnWrapper = new Column<Component, int>("recentcommitssmart", null,
            "recent" + "<br>" + "commits", null,
            new List<ColumnBase>() { recentSmartCommitsColumn, trendRecentSmartCommitsColumn });
        Column<Component, int> secondHeaderColumn = new Column<Component, int>("smartCommits", null, "Smart Commits",
            null, new List<ColumnBase>() { allSmartCommitsColumnWrapper, recentSmartCommitsColumnWrapper });

        Column<Component, int> allLiterateCommitsColumn =
            new Column<Component, int>("%allcommitsliterate", null, "%", null);
        Column<Component, int> allLiterateCommitsColumnWrapper = new Column<Component, int>("allcommitsliterate", null,
            "all" + "<br>" + "commits", null, new List<ColumnBase>() { allLiterateCommitsColumn });
        Column<Component, int> recentLiterateCommitsColumn =
            new Column<Component, int>("%recentcommitsliterate", null, "%", null, sortable: false);
        Column<Component, int> trendRecentLiterateCommitsColumn =
            new Column<Component, int>("trendrecentcommitsliterate", null, "trend", null, sortable: false);
        Column<Component, int> recentLiterateCommitsColumnWrapper = new Column<Component, int>("recentcommitsliterate",
            null, "recent" + "<br>" + "commits", null,
            new List<ColumnBase>() { recentLiterateCommitsColumn, trendRecentLiterateCommitsColumn });
        Column<Component, int> thirdHeaderColumn = new Column<Component, int>(null, null, "Literate Commits", null,
            new List<ColumnBase>() { allLiterateCommitsColumnWrapper, recentLiterateCommitsColumnWrapper });
        return new List<ColumnBase>() { firstHeaderColumn, secondHeaderColumn, thirdHeaderColumn };
    }
}