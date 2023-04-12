using TMGbe.Models;

public class QualityAssurance
{
    //not done
    public List<ColumnBase> getTableColumnData()
    {
        Column<Component, String> nameColumn = new Column<Component, string>
            ("component", "Component", null);
        Column<Component, String> nameColumnWrapper = new Column<Component, string>
            (null, "", null, null, childrenColumns: new List<ColumnBase>() { nameColumn });
        Column<Component, long> sourcefilesColumn = new Column<Component, long>
            ("#sourcefiles", "#", null);
        Column<Component, long> sourcefilesColumnWrapper = new Column<Component, long>
        ("sourcefiles", "source" + "<br>" + "files", null, null,
            childrenColumns: new List<ColumnBase>() { sourcefilesColumn });
        Column<Component, int> sourcelinesColumn = new Column<Component, int>
            ("x1000sourcelines", "x1000", null);
        Column<Component, int> sourcelinesColumnWrapper = new Column<Component, int>
        ("sourcelines", "source" + "<br>" + "lines", null, null,
            childrenColumns: new List<ColumnBase>() { sourcelinesColumn });
        Column<Component, int> sourceChangesColumn = new Column<Component, int>
            ("#sourcechanges", "#", null);
        Column<Component, int> sourceChangesColumnWrapper = new Column<Component, int>
        ("sourcechanges", "source" + "<br>" + "changes", null, null,
            childrenColumns: new List<ColumnBase>() { sourceChangesColumn });
        Column<Component, DateTime> startDateColumn = new Column<Component, DateTime>
            ("yyyy-mmstart", "yyyy-mm", null);
        Column<Component, int> startDateColumnWrapper = new Column<Component, int>
            ("startDate", "start date", null, null, childrenColumns: new List<ColumnBase>() { startDateColumn });
        Column<Component, DateTime> latestDateColumn = new Column<Component, DateTime>
            ("yyyy-mmlatest", "yyyy-mm", null);
        Column<Component, int> latestDateColumnWrapper = new Column<Component, int>
            ("latestDate", "latest date", null, null, childrenColumns: new List<ColumnBase>() { latestDateColumn });
        Column<Component, int> firstHeaderColumn = new Column<Component, int>
        (null, "", null, null, childrenColumns: new List<ColumnBase>()
        {
            nameColumnWrapper, sourcefilesColumnWrapper, sourcelinesColumnWrapper, sourceChangesColumnWrapper,
            startDateColumnWrapper,
            latestDateColumnWrapper
        });

        Column<Component, int> testFilesColumn = new Column<Component, int>
            ("%testfiles", "%", null);
        Column<Component, int> testFilesColumnWrapper = new Column<Component, int>
        ("testfiles", "test" + "<br>" + "files", null, null,
            childrenColumns: new List<ColumnBase>() { testFilesColumn });
        Column<Component, int> testFilesCreatedColumnOne = new Column<Component, int>
            ("%testfilescreated", "%", null);
        Column<Component, int> testFilesCreatedColumnTwo = new Column<Component, int>
            ("testfilescreatedtrend", "trend", null,borderR:true);
        Column<Component, int> testFilesCreatedColumnWrapper = new Column<Component, int>
        ("testfilescreated", "created" + "<br>" + "recently", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>() { testFilesCreatedColumnOne, testFilesCreatedColumnTwo });
        Column<Component, int> secondHeaderColumn = new Column<Component, int>
        (null, "Test Files", null, null,borderR:true, childrenColumns: new List<ColumnBase>()
        {
            testFilesColumnWrapper, testFilesCreatedColumnWrapper
        }, description: "only source-code");

        Column<Component, int> testLinesColumn = new Column<Component, int>
            ("%testlines", "%", null);
        Column<Component, int> testLinesColumnWrapper = new Column<Component, int>
        ("testlines", "test" + "<br>" + "lines", null, null,
            childrenColumns: new List<ColumnBase>() { testLinesColumn });
        Column<Component, int> testLinesGrowthColumnOne = new Column<Component, int>
            ("%testlinesgrowth", "%", null);
        Column<Component, int> testLinesGrowthColumnTwo = new Column<Component, int>
            ("testlinesgrowthtrend", "trend", null,borderR:true);
        Column<Component, int> testLinesGrowthColumnWrapper = new Column<Component, int>
        ("testlinesgrowth", "recent" + "<br>" + "growth", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>() { testLinesGrowthColumnOne, testLinesGrowthColumnTwo });
        Column<Component, int> thirdHeaderColumn = new Column<Component, int>
        (null, "Test Code Size", null, null, borderR:true,childrenColumns: new List<ColumnBase>()
        {
            testLinesColumnWrapper, testLinesGrowthColumnWrapper
        }, description: "only source-code");

        Column<Component, int> testChangesColumn = new Column<Component, int>
            ("%testchanges", "%", null);
        Column<Component, int> testChangesColumnWrapper = new Column<Component, int>
        ("testchanges", "test" + "<br>" + "changes", null, null,
            childrenColumns: new List<ColumnBase>() { testChangesColumn });
        Column<Component, int> testChangesRecentColumnOne = new Column<Component, int>
            ("%testchangesrecent", "%", null);
        Column<Component, int> testChangesRecentColumnTwo = new Column<Component, int>
            ("testchangesrecenttrend", "trend", null,borderR:true);
        Column<Component, int> testChangesRecentColumnWrapper = new Column<Component, int>
        ("testchangesrecent", "recent" + "<br>" + "changes", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>() { testChangesRecentColumnOne, testChangesRecentColumnTwo });
        Column<Component, int> fourthHeaderColumn = new Column<Component, int>
        (null, "Test Changes", null, null,borderR:true, childrenColumns: new List<ColumnBase>()
        {
            testChangesColumnWrapper, testChangesRecentColumnWrapper
        }, description: "only source-code");

        Column<Component, int> filesBugMagnetColumn = new Column<Component, int>
            ("#filesbugmagnet", "#", null);
        Column<Component, int> filesBugMagnetColumnWrapper = new Column<Component, int>
        ("filesbugmagnet", "source" + "<br>" + "files", null, null,
            childrenColumns: new List<ColumnBase>() { filesBugMagnetColumn });
        Column<Component, int> createdBugMagnetColumnOne = new Column<Component, int>
            ("#createdbugmagnet", "#", null);
        Column<Component, int> createdBugMagnetColumnTwo = new Column<Component, int>
            ("createdbugmagnettrend", "trend", null,borderR:true);
        Column<Component, int> createdBugMagnetColumnWrapper = new Column<Component, int>
        ("createdbugmagnet", "created" + "<br>" + "recently", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>() { createdBugMagnetColumnOne, createdBugMagnetColumnTwo });
        Column<Component, int> fifthHeaderColumn = new Column<Component, int>
        (null, "Bug Magnets", null, null,borderR:true, childrenColumns: new List<ColumnBase>()
        {
            testLinesColumnWrapper, testLinesGrowthColumnWrapper
        }, description: "source-files with many" + "<br>" + "bug-fixing changes");

        Column<Component, int> allBugCommitsColumn = new Column<Component, int>
            ("%allcommitsbug", "%", null);
        Column<Component, int> allBugCommitsColumnWrapper = new Column<Component, int>
        ("allcommitsbug", "all" + "<br>" + "commits", null, null,
            childrenColumns: new List<ColumnBase>() { allBugCommitsColumn });
        Column<Component, int> recentBugCommitsColumn = new Column<Component, int>
            ("%recentcommitsbug", "%", null, null, sortable: false);
        Column<Component, int> trendRecentBugCommitsColumn = new Column<Component, int>
            ("trendrecentcommitsbug", "trend", null, null, sortable: false,borderR:true);
        Column<Component, int> recentBugCommitsColumnWrapper = new Column<Component, int>
        ("recentcommitsbug", "recent" + "<br>" + "commits", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>() { recentBugCommitsColumn, trendRecentBugCommitsColumn });
        Column<Component, int> sixthHeaderColumn = new Column<Component, int>
        ("bugFixes", "Bug Fixes", null, null, borderR:true,childrenColumns: new List<ColumnBase>()
                { allBugCommitsColumnWrapper, recentBugCommitsColumnWrapper }
            , description: "commits with message" + "<br>" + "suggesting bug-fix");

        Column<Component, int> allFilesCoveredFunctionalColumn = new Column<Component, int>
            ("%allFilesCoveredFunctional", "%", null);
        Column<Component, int> allFilesCoveredFunctionalColumnWrapper = new Column<Component, int>
        ("allFilesCoveredFunctional", "all files" + "<br>" + "covered", null, null,
            childrenColumns: new List<ColumnBase>() { allFilesCoveredFunctionalColumn });
        Column<Component, int> recentlyCreatedFilesCoveredColumnOne = new Column<Component, int>
            ("%recentlycreatedfilescovered", "%", null);
        Column<Component, int> recentlyCreatedFilesCoveredColumnTwo = new Column<Component, int>
            ("trendrecentlycreatedfilescovered", "trend", null);
        Column<Component, int> recentlyCreatedFilesCoveredColumnWrapper = new Column<Component, int>
        ("recentlycreatedfilescovered", "recently" + "<br>" + "created files" + "<br>" + "covered", null, null,
            childrenColumns: new List<ColumnBase>()
                { recentlyCreatedFilesCoveredColumnOne, recentlyCreatedFilesCoveredColumnTwo });
        Column<Component, int> allCriticalFilesCoveredFunctionalColumn = new Column<Component, int>
            ("%allCriticalFilesCoveredFunctional", "%", null);
        Column<Component, int> allCriticalFilesCoveredFunctionalColumnWrapper = new Column<Component, int>
        ("allCriticalFilesCoveredFunctional", "critical" + "<br>" + " files" + "<br>" + "covered", null, null,
            childrenColumns: new List<ColumnBase>() { allCriticalFilesCoveredFunctionalColumn });
        Column<Component, int> recentlyCreatedFilesCovered2ColumnOne = new Column<Component, int>
            ("%recentlycreatedfilescovered2", "%", null);
        Column<Component, int> recentlyCreatedFilesCovered2ColumnTwo = new Column<Component, int>
            ("trendrecentlycreatedfilescovered2", "trend", null);
        Column<Component, int> recentlyCreatedFilesCovered2ColumnWrapper = new Column<Component, int>
        ("recentlycreatedfilescovered2", "recently" + "<br>" + "created files" + "<br>" + "covered", null, null,
            childrenColumns: new List<ColumnBase>()
                { recentlyCreatedFilesCovered2ColumnOne, recentlyCreatedFilesCovered2ColumnTwo });
        Column<Component, int> seventhHeaderColumn = new Column<Component, int>
        ("functionalFiles", "Functional Files" + "<br>" + "covered by test references", null,
            null, childrenColumns: new List<ColumnBase>() { allBugCommitsColumnWrapper, recentBugCommitsColumnWrapper }
            , description: "functional source-files with references from test code files. \"Critical" + "<br>" + "files\" are large, complex and heavily changed ");

        //last table column missing
        return new List<ColumnBase>()
        {
            firstHeaderColumn, secondHeaderColumn, thirdHeaderColumn, fourthHeaderColumn, fifthHeaderColumn,
            sixthHeaderColumn, seventhHeaderColumn /*and eight*/
        };
    }
}