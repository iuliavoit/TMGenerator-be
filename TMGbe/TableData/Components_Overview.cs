 using TMGbe.Models;

 public class ComponentsOverview
 {
     public List<ColumnBase> getComponentsOverviewTableColumnData()
     {

         Column<Component, String> nameColumn =
             new Column<Component, string>("component", null, "Component", null);
         Column<Component, String> nameColumnWrapper =
             new Column<Component, string>(null, null, "", null, new List<ColumnBase>() { nameColumn });
         Column<Component, String> startedInColumn =
             new Column<Component, string>("yyyy-mmStarted", null, "yyyy-mm", null);
         Column<Component, String> startedInColumnWrapper =
             new Column<Component, string>("startedIn", null, "started in", null,
                 new List<ColumnBase>() { startedInColumn });
         Column<Component, String> dateSimpleColumn =
             new Column<Component, string>("yyyy-mmSimple", null, "yyyy-mm", null);
         Column<Component, String> dateSimpleColumnWrapper =
             new Column<Component, string>(null, null, "", null, new List<ColumnBase>() { dateSimpleColumn });
         Column<Component, int> firstHeaderColumn = new Column<Component, int>(null, null, "", null,
             new List<ColumnBase>()
             {
                 nameColumnWrapper, startedInColumnWrapper, dateSimpleColumnWrapper
             });

         Column<Component, long> filesColumn =
             new Column<Component, long>("#files", null, "#", null);
         Column<Component, long> filesColumnWrapper =
             new Column<Component, long>("allfiles", null, "all" + "<br>" + "files", null,
                 new List<ColumnBase>() { filesColumn });
         Column<Component, long> importedFilesColumnOne =
             new Column<Component, long>("#importedfiles", null, "#", null);
         Column<Component, long> importedFilesColumnTwo =
             new Column<Component, long>("%allimportedfiles", null, "%all", null);
         Column<Component, long> importedfilesColumnWrapper =
             new Column<Component, long>("importedfiles", null, "imported" + "<br>" + "files", null,
                 new List<ColumnBase>() { importedFilesColumnOne, importedFilesColumnTwo });
         Column<Component, long> sourceFilesColumnOne =
             new Column<Component, long>("#sourcefiles", null, "#", null);
         Column<Component, long> sourceFilesColumnTwo =
             new Column<Component, long>("%allsourcefiles", null, "%all", null);
         Column<Component, long> sourcefilesColumnWrapper =
             new Column<Component, long>("sourcefiles", null, "source" + "<br>" + "files", null,
                 new List<ColumnBase>() { sourceFilesColumnOne, sourceFilesColumnTwo });
         Column<Component, long> activeFilesColumnOne =
             new Column<Component, long>("#activefiles", null, "#", null);
         Column<Component, long> activeFilesColumnTwo =
             new Column<Component, long>("%allactivefiles", null, "%all", null);
         Column<Component, long> activefilesColumnWrapper =
             new Column<Component, long>("activefiles", null, "active" + "<br>" + "recently", null,
                 new List<ColumnBase>() { activeFilesColumnOne, activeFilesColumnTwo });
         Column<Component, long> createdFilesColumnOne =
             new Column<Component, long>("#createdfiles", null, "#", null);
         Column<Component, long> createdFilesColumnTwo =
             new Column<Component, long>("%allcreatedfiles", null, "%all", null);
         Column<Component, long> createdfilesColumnWrapper =
             new Column<Component, long>("createdfiles", null, "created" + "<br>" + "recently", null,
                 new List<ColumnBase>() { createdFilesColumnOne, createdFilesColumnTwo });
         Column<Component, int> secondHeaderColumn = new Column<Component, int>(null, null, "Files", null,
             new List<ColumnBase>()
             {
                 filesColumnWrapper, importedfilesColumnWrapper, sourcefilesColumnWrapper, activefilesColumnWrapper,
                 createdfilesColumnWrapper
             });

         Column<Component, int> linesColumn = new Column<Component, int>("x1000lines", null, "x1000", null);
         Column<Component, int> linesColumnWrapper = new Column<Component, int>("alllines", null,
             "all" + "<br>" + "lines", null, new List<ColumnBase>() { linesColumn });
         Column<Component, int> sourceCodeColumnOne = new Column<Component, int>("x1000source", null, "x1000", null);
         Column<Component, int> sourceCodeColumnTwo = new Column<Component, int>("%allsource", null, "%all", null);
         Column<Component, int> sourceColumnWrapper = new Column<Component, int>("source", null,
             "source" + "<br>" + "code lines", null,
             new List<ColumnBase>() { sourceCodeColumnOne, sourceCodeColumnTwo });
         Column<Component, int> growthCodeColumnOne = new Column<Component, int>("x1000growth", null, "x1000", null);
         Column<Component, int> growthCodeColumnTwo = new Column<Component, int>("%allgrowth", null, "%all", null);
         Column<Component, int> growthColumnWrapper = new Column<Component, int>("growth", null,
             "growth recent", null,
             new List<ColumnBase>() { growthCodeColumnOne, growthCodeColumnTwo });
         Column<Component, int> thirdHeaderColumn = new Column<Component, int>(null, null, "Code Size", null,
             new List<ColumnBase>()
             {
                 linesColumnWrapper, sourceColumnWrapper, growthColumnWrapper
             });

         Column<Component, int> devsColumn = new Column<Component, int>("#devs", null, "#", null);
         Column<Component, int> devsColumnWrapper = new Column<Component, int>("alldevs", null,
             "all" + "<br>" + "devs", null, new List<ColumnBase>() { devsColumn });
         Column<Component, long> activeDevsColumnOne =
             new Column<Component, long>("#activedevs", null, "#", null);
         Column<Component, long> activeDevsColumnTwo =
             new Column<Component, long>("%allactivedevs", null, "%all", null);
         Column<Component, long> activeDevsColumnWrapper =
             new Column<Component, long>("activeDevs", null, "active" + "<br>" + "recently", null,
                 new List<ColumnBase>() { activeDevsColumnOne, activeDevsColumnTwo });
         Column<Component, long> joinedDevsColumnOne =
             new Column<Component, long>("#joineddevs", null, "#", null);
         Column<Component, long> joinedDevsColumnTwo =
             new Column<Component, long>("%alljoineddevs", null, "%all", null);
         Column<Component, long> joinedDevsColumnWrapper =
             new Column<Component, long>("joinedDevs", null, "joined" + "<br>" + "recently", null,
                 new List<ColumnBase>() { joinedDevsColumnOne, joinedDevsColumnTwo });
         Column<Component, int> fourthHeaderColumn = new Column<Component, int>(null, null, "Developers", null,
             new List<ColumnBase>()
             {
                 devsColumnWrapper, activeDevsColumnWrapper, joinedDevsColumnWrapper
             });

         Column<Component, int> commitsColumn = new Column<Component, int>("#commits", null, "#", null);
         Column<Component, int> commitsColumnWrapper = new Column<Component, int>("allcommits", null,
             "all" + "<br>" + "com.", null, new List<ColumnBase>() { commitsColumn });
         Column<Component, long> allCommitsColumnOne =
             new Column<Component, long>("#recentcommits", null, "#", null);
         Column<Component, long> allCommitsColumnTwo =
             new Column<Component, long>("%allrecentcommits", null, "%all", null);
         Column<Component, long> allCommitsColumnWrapper =
             new Column<Component, long>("commits", null, "recent" + "<br>" + "commits", null,
                 new List<ColumnBase>() { allCommitsColumnOne, allCommitsColumnTwo });
         Column<Component, int> fifthHeaderColumn = new Column<Component, int>(null, null, "Commits", null,
             new List<ColumnBase>()
             {
                 commitsColumnWrapper, allCommitsColumnWrapper
             });

         Column<Component, int> chumColumn = new Column<Component, int>("x1000chum", null, "x1000", null);
         Column<Component, int> chumColumnWrapper = new Column<Component, int>("chum", null, "all" + "<br>" + "chum",
             null, new List<ColumnBase>() { chumColumn });
         Column<Component, int> recentChumColumnOne =
             new Column<Component, int>("x1000recentChum", null, "x1000", null);
         Column<Component, int> recentChumColumnTwo = new Column<Component, int>("%allRecentChum", null, "%all", null);
         Column<Component, int> recentChumColumnWrapper = new Column<Component, int>("recentChum", null,
             "recent" + "<br>" + "chum", null,
             new List<ColumnBase>() { recentChumColumnOne, recentChumColumnTwo });
         Column<Component, int> sixthHeaderColumn = new Column<Component, int>(null, null, "Change Volume", null,
             new List<ColumnBase>()
             {
                 chumColumnWrapper, recentChumColumnWrapper
             });

         Column<Component, int> tasksColumn = new Column<Component, int>("#tasks", null, "#", null);
         Column<Component, int> tasksColumnWrapper = new Column<Component, int>("alltasks", null,
             "all" + "<br>" + "tasks", null, new List<ColumnBase>() { tasksColumn });
         Column<Component, long> allTasksColumnOne =
             new Column<Component, long>("#recenttasks", null, "#", null);
         Column<Component, long> allTasksColumnTwo =
             new Column<Component, long>("%allrecenttasks", null, "%all", null);
         Column<Component, long> allTasksColumnWrapper =
             new Column<Component, long>("tasks", null, "recent" + "<br>" + "tasks", null,
                 new List<ColumnBase>() { allTasksColumnOne, allTasksColumnTwo });
         Column<Component, int> seventhHeaderColumn = new Column<Component, int>(null, null, "Tasks", null,
             new List<ColumnBase>()
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