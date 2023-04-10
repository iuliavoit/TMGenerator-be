using TMGbe.Models;

public class QualityAssurance
{
    //not done
      public List<ColumnBase> getQualityAssuranceTableData()
    {
        Column<Component, String> nameColumn =
            new Column<Component, string>("component", null, "Component", null);
        Column<Component, String> nameColumnWrapper =
            new Column<Component, string>(null, null, "", null, new List<ColumnBase>() { nameColumn });
        Column<Component, long> sourcefilesColumn =
            new Column<Component, long>("#sourcefiles", null, "#", null);
        Column<Component, long> sourcefilesColumnWrapper =
            new Column<Component, long>("sourcefiles", null, "source" + "<br>" + "files", null,
                new List<ColumnBase>() { sourcefilesColumn });
        Column<Component, int> sourcelinesColumn = new Column<Component, int>("x1000sourcelines", null, "x1000", null);
        Column<Component, int> sourcelinesColumnWrapper = new Column<Component, int>("sourcelines", null,
            "source" + "<br>" + "lines", null, new List<ColumnBase>() { sourcelinesColumn });
        Column<Component, int> sourceChangesColumn = new Column<Component, int>("#sourcechanges", null, "#", null);
        Column<Component, int> sourceChangesColumnWrapper = new Column<Component, int>("sourcechanges", null,
            "source" + "<br>" + "changes", null, new List<ColumnBase>() { sourceChangesColumn });
        Column<Component, int> startDateColumn = new Column<Component, int>("yyyy-mmstart", null, "yyyy-mm", null);
        Column<Component, int> startDateColumnWrapper = new Column<Component, int>("startDate", null, "start date",
            null, new List<ColumnBase>() { startDateColumn });
        Column<Component, int> latestDateColumn = new Column<Component, int>("yyyy-mmlatest", null, "yyyy-mm", null);
        Column<Component, int> latestDateColumnWrapper = new Column<Component, int>("latestDate", null, "latest date",
            null, new List<ColumnBase>() { latestDateColumn });
        Column<Component, int> firstHeaderColumn = new Column<Component, int>(null, null, "", null,
            new List<ColumnBase>()
            {
                nameColumnWrapper, sourcefilesColumnWrapper, sourcelinesColumnWrapper, sourceChangesColumnWrapper,
                startDateColumnWrapper,
                latestDateColumnWrapper
            });

        Column<Component, int> testFilesColumn = new Column<Component, int>("%testfiles", null, "%", null);
        Column<Component, int> testFilesColumnWrapper = new Column<Component, int>("testfiles", null,
            "test" + "<br>" + "files", null, new List<ColumnBase>() { testFilesColumn });
        Column<Component, int> testFilesCreatedColumnOne =
            new Column<Component, int>("%testfilescreated", null, "%", null);
        Column<Component, int> testFilesCreatedColumnTwo =
            new Column<Component, int>("testfilescreatedtrend", null, "trend", null);
        Column<Component, int> testFilesCreatedColumnWrapper =
            new Column<Component, int>("testfilescreated", null, "created" + "<br>" + "recently", null,
                new List<ColumnBase>() { testFilesCreatedColumnOne, testFilesCreatedColumnTwo });
        Column<Component, int> secondHeaderColumn = new Column<Component, int>(null, null, "Test Files", null,
            new List<ColumnBase>()
            {
                testFilesColumnWrapper, testFilesCreatedColumnWrapper
            } /*, description:"only source-code"*/);

        Column<Component, int> testLinesColumn = new Column<Component, int>("%testlines", null, "%", null);
        Column<Component, int> testLinesColumnWrapper = new Column<Component, int>("testlines", null,
            "test" + "<br>" + "lines", null, new List<ColumnBase>() { testLinesColumn });
        Column<Component, int> testLinesGrowthColumnOne =
            new Column<Component, int>("%testlinesgrowth", null, "%", null);
        Column<Component, int> testLinesGrowthColumnTwo =
            new Column<Component, int>("testlinesgrowthtrend", null, "trend", null);
        Column<Component, int> testLinesGrowthColumnWrapper =
            new Column<Component, int>("testlinesgrowth", null, "recent" + "<br>" + "growth", null,
                new List<ColumnBase>() { testLinesGrowthColumnOne, testLinesGrowthColumnTwo });
        Column<Component, int> thirdHeaderColumn = new Column<Component, int>(null, null, "Test Code Size", null,
            new List<ColumnBase>()
            {
                testLinesColumnWrapper, testLinesGrowthColumnWrapper
            } /*, description:"only source-code"*/);

        Column<Component, int> testChangesColumn = new Column<Component, int>("%testchanges", null, "%", null);
        Column<Component, int> testChangesColumnWrapper = new Column<Component, int>("testchanges", null,
            "test" + "<br>" + "changes", null, new List<ColumnBase>() { testChangesColumn });
        Column<Component, int> testChangesRecentColumnOne =
            new Column<Component, int>("%testchangesrecent", null, "%", null);
        Column<Component, int> testChangesRecentColumnTwo =
            new Column<Component, int>("testchangesrecenttrend", null, "trend", null);
        Column<Component, int> testChangesRecentColumnWrapper =
            new Column<Component, int>("testchangesrecent", null, "recent" + "<br>" + "changes", null,
                new List<ColumnBase>() { testChangesRecentColumnOne, testChangesRecentColumnTwo });
        Column<Component, int> fourthHeaderColumn = new Column<Component, int>(null, null, "Test Changes", null,
            new List<ColumnBase>()
            {
                testChangesColumnWrapper, testChangesRecentColumnWrapper
            } /*, description:"only source-code"*/);


        Column<Component, int> filesBugMagnetColumn = new Column<Component, int>("#filesbugmagnet", null, "#", null);
        Column<Component, int> filesBugMagnetColumnWrapper = new Column<Component, int>("filesbugmagnet", null,
            "source" + "<br>" + "files", null, new List<ColumnBase>() { filesBugMagnetColumn });
        Column<Component, int> createdBugMagnetColumnOne =
            new Column<Component, int>("#createdbugmagnet", null, "#", null);
        Column<Component, int> createdBugMagnetColumnTwo =
            new Column<Component, int>("createdbugmagnettrend", null, "trend", null);
        Column<Component, int> createdBugMagnetColumnWrapper =
            new Column<Component, int>("createdbugmagnet", null, "created" + "<br>" + "recently", null,
                new List<ColumnBase>() { createdBugMagnetColumnOne, createdBugMagnetColumnTwo });
        Column<Component, int> fifthHeaderColumn = new Column<Component, int>(null, null, "Bug Magnets", null,
            new List<ColumnBase>()
            {
                testLinesColumnWrapper, testLinesGrowthColumnWrapper
            } /*, description:"source-files with many"+"<br>" + "bug-fixing changes" */);

        Column<Component, int> allBugCommitsColumn = new Column<Component, int>("%allcommitsbug", null, "%", null);
        Column<Component, int> allBugCommitsColumnWrapper = new Column<Component, int>("allcommitsbug", null,
            "all" + "<br>" + "commits", null, new List<ColumnBase>() { allBugCommitsColumn });
        Column<Component, int> recentBugCommitsColumn =
            new Column<Component, int>("%recentcommitsbug", null, "%", null, sortable: false);
        Column<Component, int> trendRecentBugCommitsColumn =
            new Column<Component, int>("trendrecentcommitsbug", null, "trend", null, sortable: false);
        Column<Component, int> recentBugCommitsColumnWrapper = new Column<Component, int>("recentcommitsbug", null,
            "recent" + "<br>" + "commits", null,
            new List<ColumnBase>() { recentBugCommitsColumn, trendRecentBugCommitsColumn });
        Column<Component, int> sixthHeaderColumn = new Column<Component, int>("bugFixes", null, "Bug Fixes",
            null, new List<ColumnBase>() { allBugCommitsColumnWrapper, recentBugCommitsColumnWrapper }
            /*, description:"commits with message"+"<br>" + "suggesting bug-fix" */);

        Column<Component, int> allFilesCoveredFunctionalColumn =
            new Column<Component, int>("%allFilesCoveredFunctional", null, "%", null);
        Column<Component, int> allFilesCoveredFunctionalColumnWrapper =
            new Column<Component, int>("allFilesCoveredFunctional", null, "all files" + "<br>" + "covered", null,
                new List<ColumnBase>() { allFilesCoveredFunctionalColumn });
        Column<Component, int> recentlyCreatedFilesCoveredColumnOne =
            new Column<Component, int>("%recentlycreatedfilescovered", null, "%", null);
        Column<Component, int> recentlyCreatedFilesCoveredColumnTwo =
            new Column<Component, int>("trendrecentlycreatedfilescovered", null, "trend", null);
        Column<Component, int> recentlyCreatedFilesCoveredColumnWrapper =
            new Column<Component, int>("recentlycreatedfilescovered", null,
                "recently" + "<br>" + "created files" + "<br>" + "covered", null, new List<ColumnBase>()
                    {recentlyCreatedFilesCoveredColumnOne, recentlyCreatedFilesCoveredColumnTwo});
        Column<Component, int> allCriticalFilesCoveredFunctionalColumn =
            new Column<Component, int>("%allCriticalFilesCoveredFunctional", null, "%", null);
        Column<Component, int> allCriticalFilesCoveredFunctionalColumnWrapper =
            new Column<Component, int>("allCriticalFilesCoveredFunctional", null, "critical"+"<br>"+" files" + "<br>" + "covered", null,
                new List<ColumnBase>() { allCriticalFilesCoveredFunctionalColumn });
        Column<Component, int> recentlyCreatedFilesCovered2ColumnOne =
            new Column<Component, int>("%recentlycreatedfilescovered2", null, "%", null);
        Column<Component, int> recentlyCreatedFilesCovered2ColumnTwo =
            new Column<Component, int>("trendrecentlycreatedfilescovered2", null, "trend", null);
        Column<Component, int> recentlyCreatedFilesCovered2ColumnWrapper =
            new Column<Component, int>("recentlycreatedfilescovered2", null,
                "recently" + "<br>" + "created files" + "<br>" + "covered", null, new List<ColumnBase>()
                    {recentlyCreatedFilesCovered2ColumnOne, recentlyCreatedFilesCovered2ColumnTwo});
        Column<Component, int> seventhHeaderColumn = new Column<Component, int>("functionalFiles", null, "Functional Files"+"<br>"+"covered by test references",
            null, new List<ColumnBase>() { allBugCommitsColumnWrapper, recentBugCommitsColumnWrapper }
            /*, description:"functional source-files with references from test code files. \"Critical" +"<br>"+"files\" are large, complex and heavily changed "*/);

        //last table column missing
        return new List<ColumnBase>() { firstHeaderColumn, secondHeaderColumn, thirdHeaderColumn, fourthHeaderColumn, fifthHeaderColumn, sixthHeaderColumn, seventhHeaderColumn /*and eight*/ };

}
}