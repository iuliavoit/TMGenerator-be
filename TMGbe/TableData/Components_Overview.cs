using TMGbe.Models;

public class ComponentsOverview
{
    public List<ColumnBase> getTableColumnData()
    {
        Column<Component, String> nameColumn = new Column<Component, string>
            ("component", "Component", "color: #6c757d;");
        Column<Component, String> nameColumnWrapper = new Column<Component, string>
            (null, "", null, childrenColumns: new List<ColumnBase>() { nameColumn });
        Column<Component, String> startedInColumn = new Column<Component, string>
            ("yyyy-mmStarted", "yyyy-mm", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, String> startedInColumnWrapper = new Column<Component, string>
            ("startedIn", "started in", "font-weight: 400;font-size: 13px;color: #6c757d;", childrenColumns: new List<ColumnBase>() { startedInColumn });
        Column<Component, String> dateSimpleColumn = new Column<Component, string>
            ("yyyy-mmSimple", "yyyy-mm", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, String> dateSimpleColumnWrapper = new Column<Component, string>
            (null, "latest <br> change", "font-weight: 400;font-size: 13px;color: #6c757d;", null, childrenColumns: new List<ColumnBase>() { dateSimpleColumn });
        Column<Component, int> firstHeaderColumn = new Column<Component, int>
        (null, "", null, null,
            childrenColumns: new List<ColumnBase>()
                { nameColumnWrapper, startedInColumnWrapper, dateSimpleColumnWrapper });

        Column<Component, long> filesColumn = new Column<Component, long>
            ("#files", "#", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, long> filesColumnWrapper = new Column<Component, long>
            ("allfiles", "all" + "<br>" + "files", "font-weight: 400;font-size: 13px;color: #6c757d;", null, childrenColumns: new List<ColumnBase>() { filesColumn });
        Column<Component, long> importedFilesColumnOne = new Column<Component, long>
            ("#importedfiles", "#", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, long> importedFilesColumnTwo = new Column<Component, long>
            ("%allimportedfiles", "%all", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, long> importedfilesColumnWrapper = new Column<Component, long>
        ("importedfiles", "imported" + "<br>" + "files", "font-weight: 400;font-size: 13px;color: #6c757d;",
            childrenColumns: new List<ColumnBase>() { importedFilesColumnOne, importedFilesColumnTwo });
        Column<Component, long> sourceFilesColumnOne = new Column<Component, long>
            ("#sourcefiles", "#", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, long> sourceFilesColumnTwo = new Column<Component, long>
            ("%allsourcefiles", "%all", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, long> sourcefilesColumnWrapper = new Column<Component, long>
        ("sourcefiles", "source" + "<br>" + "files", "font-weight: 400;font-size: 13px;color: #6c757d;", null,
            childrenColumns: new List<ColumnBase>() { sourceFilesColumnOne, sourceFilesColumnTwo });
        Column<Component, long> activeFilesColumnOne = new Column<Component, long>
            ("#activefiles", "#", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, long> activeFilesColumnTwo = new Column<Component, long>
            ("%allactivefiles", "%all", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, long> activefilesColumnWrapper = new Column<Component, long>
        ("activefiles", "active" + "<br>" + "recently", "font-weight: 400;font-size: 13px;color: #6c757d;", null,
            childrenColumns: new List<ColumnBase>() { activeFilesColumnOne, activeFilesColumnTwo });
        Column<Component, long> createdFilesColumnOne = new Column<Component, long>
            ("#createdfiles", "#", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, long> createdFilesColumnTwo = new Column<Component, long>
            ("%allcreatedfiles", "%all", "font-weight: 400;font-size: 13px;color: #6c757d;", borderR:true);
        Column<Component, long> createdfilesColumnWrapper = new Column<Component, long>
        ("createdfiles", "created" + "<br>" + "recently", "font-weight: 400;font-size: 13px;color: #6c757d;", null, borderR:true,
            childrenColumns: new List<ColumnBase>() { createdFilesColumnOne, createdFilesColumnTwo });
        Column<Component, int> secondHeaderColumn = new Column<Component, int>
        (null, "Files", null, null, borderR:true,
            childrenColumns: new List<ColumnBase>()
            {
                filesColumnWrapper, importedfilesColumnWrapper, sourcefilesColumnWrapper, activefilesColumnWrapper,
                createdfilesColumnWrapper
            });

        Column<Component, int> linesColumn = new Column<Component, int>
            ("x1000lines", "x1000", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> linesColumnWrapper = new Column<Component, int>
            ("alllines", "all" + "<br>" + "lines", "font-weight: 400;font-size: 13px;color: #6c757d;", null, childrenColumns: new List<ColumnBase>() { linesColumn });
        Column<Component, int> sourceCodeColumnOne = new Column<Component, int>
            ("x1000source", "x1000", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> sourceCodeColumnTwo = new Column<Component, int>
            ("%allsource", "%all", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> sourceColumnWrapper = new Column<Component, int>
        ("source", "source" + "<br>" + "code lines", "font-weight: 400;font-size: 13px;color: #6c757d;", null,
            childrenColumns: new List<ColumnBase>() { sourceCodeColumnOne, sourceCodeColumnTwo });
        Column<Component, int> growthCodeColumnOne = new Column<Component, int>
            ("x1000growth", "x1000", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> growthCodeColumnTwo = new Column<Component, int>
            ("%allgrowth", "%all", "font-weight: 400;font-size: 13px;color: #6c757d;",borderR:true);
        Column<Component, int> growthColumnWrapper = new Column<Component, int>
        ("growth", "growth recent", "font-weight: 400;font-size: 13px;color: #6c757d;", null, borderR:true,
            childrenColumns: new List<ColumnBase>() { growthCodeColumnOne, growthCodeColumnTwo });
        Column<Component, int> thirdHeaderColumn = new Column<Component, int>
        (null, "Code Size", null,null, borderR:true,
            childrenColumns: new List<ColumnBase>() { linesColumnWrapper, sourceColumnWrapper, growthColumnWrapper });

        Column<Component, int> devsColumn = new Column<Component, int>
            ("#devs", "#", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> devsColumnWrapper = new Column<Component, int>
            ("alldevs", "all" + "<br>" + "devs", "font-weight: 400;font-size: 13px;color: #6c757d;", null, childrenColumns: new List<ColumnBase>() { devsColumn });
        Column<Component, long> activeDevsColumnOne = new Column<Component, long>
            ("#activedevs", "#", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, long> activeDevsColumnTwo = new Column<Component, long>
            ("%allactivedevs", "%all", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, long> activeDevsColumnWrapper = new Column<Component, long>
        ("activeDevs", "active" + "<br>" + "recently", "font-weight: 400;font-size: 13px;color: #6c757d;", null,
            childrenColumns: new List<ColumnBase>() { activeDevsColumnOne, activeDevsColumnTwo });
        Column<Component, long> joinedDevsColumnOne = new Column<Component, long>
            ("#joineddevs", "#", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, long> joinedDevsColumnTwo = new Column<Component, long>
            ("%alljoineddevs", "%all", "font-weight: 400;font-size: 13px;color: #6c757d;",borderR:true);
        Column<Component, long> joinedDevsColumnWrapper = new Column<Component, long>
        ("joinedDevs", "joined" + "<br>" + "recently", "font-weight: 400;font-size: 13px;color: #6c757d;", null,borderR:true,
            childrenColumns: new List<ColumnBase>() { joinedDevsColumnOne, joinedDevsColumnTwo });
        Column<Component, int> fourthHeaderColumn = new Column<Component, int>(null, "Developers", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>()
            {
                devsColumnWrapper, activeDevsColumnWrapper, joinedDevsColumnWrapper
            });

        Column<Component, int> commitsColumn = new Column<Component, int>
            ("#commits", "#","font-weight: 400;font-size: 13px;color: #6c757d;",  null);
        Column<Component, int> commitsColumnWrapper = new Column<Component, int>
        ("allcommits", "all" + "<br>" + "com.", "font-weight: 400;font-size: 13px;color: #6c757d;", null,
            childrenColumns: new List<ColumnBase>() { commitsColumn });
        Column<Component, long> allCommitsColumnOne = new Column<Component, long>
            ("#recentcommits", "#", "font-weight: 400;font-size: 13px;color: #6c757d;", null);
        Column<Component, long> allCommitsColumnTwo = new Column<Component, long>
            ("%allrecentcommits", "%all", "font-weight: 400;font-size: 13px;color: #6c757d;", borderR:true);
        Column<Component, long> allCommitsColumnWrapper = new Column<Component, long>
        ("commits", "recent" + "<br>" + "commits", "font-weight: 400;font-size: 13px;color: #6c757d;", null,borderR:true,
            childrenColumns: new List<ColumnBase>() { allCommitsColumnOne, allCommitsColumnTwo });
        Column<Component, int> fifthHeaderColumn = new Column<Component, int>
        (null, "Commits", null, null,borderR:true, childrenColumns: new List<ColumnBase>()
        {
            commitsColumnWrapper, allCommitsColumnWrapper
        });

        Column<Component, int> chumColumn = new Column<Component, int>
            ("x1000chum", "x1000", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> chumColumnWrapper = new Column<Component, int>
            ("chum", "all" + "<br>" + "chum", "font-weight: 400;font-size: 13px;color: #6c757d;", null, childrenColumns: new List<ColumnBase>() { chumColumn });
        Column<Component, int> recentChumColumnOne = new Column<Component, int>
            ("x1000recentChum", "x1000", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> recentChumColumnTwo = new Column<Component, int>
            ("%allRecentChum", "%all", "font-weight: 400;font-size: 13px;color: #6c757d;",borderR:true);
        Column<Component, int> recentChumColumnWrapper = new Column<Component, int>
        ("recentChum", "recent" + "<br>" + "chum", "font-weight: 400;font-size: 13px;color: #6c757d;", null,borderR:true,
            childrenColumns: new List<ColumnBase>() { recentChumColumnOne, recentChumColumnTwo });
        Column<Component, int> sixthHeaderColumn = new Column<Component, int>
        (null, "Change Volume", null, null,borderR:true, childrenColumns: new List<ColumnBase>()
        {
            chumColumnWrapper, recentChumColumnWrapper
        });

        Column<Component, int> tasksColumn = new Column<Component, int>
            ("#tasks", "#", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, int> tasksColumnWrapper = new Column<Component, int>
            ("alltasks", "all" + "<br>" + "tasks", "font-weight: 400;font-size: 13px;color: #6c757d;", null, childrenColumns: new List<ColumnBase>() { tasksColumn });
        Column<Component, long> allTasksColumnOne = new Column<Component, long>
            ("#recenttasks", "#", "font-weight: 400;font-size: 13px;color: #6c757d;", null);
        Column<Component, long> allTasksColumnTwo = new Column<Component, long>
            ("%allrecenttasks", "%all", "font-weight: 400;font-size: 13px;color: #6c757d;");
        Column<Component, long> allTasksColumnWrapper = new Column<Component, long>
        ("tasks", "recent" + "<br>" + "tasks", "font-weight: 400;font-size: 13px;color: #6c757d;", null,
            childrenColumns: new List<ColumnBase>() { allTasksColumnOne, allTasksColumnTwo });
        Column<Component, int> seventhHeaderColumn = new Column<Component, int>
        (null, "Tasks", null, null, childrenColumns: new List<ColumnBase>()
        {
            tasksColumnWrapper, allTasksColumnWrapper
        });

        return new List<ColumnBase>()
        {
            firstHeaderColumn, secondHeaderColumn, thirdHeaderColumn, fourthHeaderColumn, fifthHeaderColumn,
            sixthHeaderColumn, seventhHeaderColumn
        };
    }
}