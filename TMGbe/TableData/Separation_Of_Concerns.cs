using TMGbe.Models;

public class SeparationOfConcerns
{
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

        Column<Component, int> sizeOutlierFilesColumnOne = new Column<Component, int>
            ("sizeOutlierFiles#", "#", null);
        Column<Component, int> sizeOutlierFilesColumnTwo = new Column<Component, int>
            ("sizeOutlierFiles%src", "%src", null);
        Column<Component, int> sizeOutlierFilesColumnWrapper = new Column<Component, int>
        (null, "outlier" + "<br>" + "files", null, null,
            childrenColumns: new List<ColumnBase>() { sizeOutlierFilesColumnOne, sizeOutlierFilesColumnTwo });
        Column<Component, int> sizeOutlierLinesColumnOne = new Column<Component, int>
            ("sizeOutlierLines#", "#", null);
        Column<Component, int> sizeOutlierLinesColumnTwo = new Column<Component, int>
            ("sizeOutlierLines%src", "%src", null);
        Column<Component, int> sizeOutlierLinesColumnWrapper = new Column<Component, int>
        (null, "outlier" + "<br>" + "lines", null, null,
            childrenColumns: new List<ColumnBase>() { sizeOutlierLinesColumnOne, sizeOutlierLinesColumnTwo });
        Column<Component, int> activeSizeOutlierColumnOne = new Column<Component, int>
            ("activeSizeOutlier#", "#", null, null);
        Column<Component, int> activeSizeOutlierColumnTwo = new Column<Component, int>
            ("activeSizeOutlier%outl", "%outl.", null, null);
        Column<Component, int> activeSizeOutlierColumnWrapper = new Column<Component, int>
        (null, "active" + "<br>" + "recently", null, null,
            childrenColumns: new List<ColumnBase>() { activeSizeOutlierColumnOne, activeSizeOutlierColumnTwo });
        Column<Component, int> createdSizeOutlierColumnOne = new Column<Component, int>
            ("createdSizeOutlier#", "#", null);
        Column<Component, int> createdSizeOutlierColumnTwo = new Column<Component, int>
            ("createdSizeOutlier%outl", "%outl.", null,borderR:true);
        Column<Component, int> createdSizeOutlierColumnWrapper = new Column<Component, int>
        (null, "created" + "<br>" + "recently", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>() { createdSizeOutlierColumnOne, createdSizeOutlierColumnTwo });
        Column<Component, int> secondHeaderColumn = new Column<Component, int>
        (null, "Size Outliers", null, null,borderR:true, childrenColumns: new List<ColumnBase>()
        {
            sizeOutlierFilesColumnWrapper, sizeOutlierLinesColumnWrapper, activeSizeOutlierColumnWrapper,
            createdSizeOutlierColumnWrapper
        }, description: "large source-code files of 500+ lines ");

        Column<Component, int> complexityOutlierFilesColumnOne = new Column<Component, int>
            ("complexityOutlierFiles#", "#", null);
        Column<Component, int> complexityOutlierFilesColumnTwo = new Column<Component, int>
            ("complexityOutlierFiles%src", "%src", null);
        Column<Component, int> complexityOutlierFilesColumnWrapper = new Column<Component, int>
        (null, "outlier" + "<br>" + "files", null, null,
            childrenColumns: new List<ColumnBase>()
                { complexityOutlierFilesColumnOne, complexityOutlierFilesColumnTwo });
        Column<Component, int> complexityOutlierLinesColumnOne = new Column<Component, int>
            ("complexityOutlierLines#", "#", null);
        Column<Component, int> complexityOutlierLinesColumnTwo = new Column<Component, int>
            ("complexityOutlierLines%src", "%src", null);
        Column<Component, int> complexityOutlierLinesColumnWrapper = new Column<Component, int>
        (null, "outlier" + "<br>" + "lines", null, null,
            childrenColumns: new List<ColumnBase>()
                { complexityOutlierLinesColumnOne, complexityOutlierLinesColumnTwo });
        Column<Component, int> activeComplexityOutlierColumnOne = new Column<Component, int>
            ("activeSizeOutlier#", "#", null, null);
        Column<Component, int> activeComplexityOutlierColumnTwo = new Column<Component, int>
            ("activeComplexityOutlier%outl", "%outl.", null);
        Column<Component, int> activeComplexityOutlierColumnWrapper = new Column<Component, int>
        (null, "active" + "<br>" + "recently", null, null,
            childrenColumns: new List<ColumnBase>()
                { activeComplexityOutlierColumnOne, activeComplexityOutlierColumnTwo });
        Column<Component, int> createdComplexityOutlierColumnOne = new Column<Component, int>
            ("createdComplexityOutlier#", "#", null);
        Column<Component, int> createdComplexityOutlierColumnTwo = new Column<Component, int>
            ("createdComplexityeOutlier%outl", "%outl.", null,borderR:true);
        Column<Component, int> createdComplexityOutlierColumnWrapper = new Column<Component, int>
        (null, "created" + "<br>" + "recently", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>()
                { createdComplexityOutlierColumnOne, createdComplexityOutlierColumnTwo });
        Column<Component, int> thirdHeaderColumn = new Column<Component, int>
        (null, "Complexity Outliers", null, null,borderR:true, childrenColumns: new List<ColumnBase>()
        {
            complexityOutlierFilesColumnWrapper, complexityOutlierLinesColumnWrapper,
            activeComplexityOutlierColumnWrapper, createdComplexityOutlierColumnWrapper
        }, description: "source-code files with complexity warnings");

        Column<Component, long> pivotFilesColumn = new Column<Component, long>
            ("#pivotfiles", "#", null);
        Column<Component, long> pivotFilesColumnWrapper = new Column<Component, long>
            ("pivotfiles", "files", null, null, childrenColumns: new List<ColumnBase>() { pivotFilesColumn });
        Column<Component, int> activePivotColumnOne = new Column<Component, int>
            ("activepivot#", "#", null);
        Column<Component, int> activePivotColumnTwo = new Column<Component, int>
            ("activepivot%all", "%all", null,borderR:true);
        Column<Component, int> activePivotColumnWrapper = new Column<Component, int>
        (null, "active" + "<br>" + "recently", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>() { activePivotColumnOne, activePivotColumnTwo });
        Column<Component, int> fourthHeaderColumn = new Column<Component, int>
        (null, "Pivot Files", null, null, borderR:true, childrenColumns: new List<ColumnBase>()
        {
            pivotFilesColumnWrapper, activePivotColumnWrapper
        }, description: "files co-changing with" + "<br>" + "many files");

        Column<Component, long> taskBottleneckFilesColumn = new Column<Component, long>
            ("#taskBottleneckfiles", "#", null);
        Column<Component, long> taskBottleneckFilesColumnWrapper = new Column<Component, long>
        ("taskBottleneckfiles", "files", null, null,
            childrenColumns: new List<ColumnBase>() { taskBottleneckFilesColumn });
        Column<Component, int> activetaskBottleneckColumnOne = new Column<Component, int>
            ("activetaskBottleneck#", "#", null);
        Column<Component, int> activetaskBottleneckColumnTwo = new Column<Component, int>
            ("activetaskBottleneck%all", "%all", null,borderR:true);
        Column<Component, int> activetaskBottleneckColumnWrapper = new Column<Component, int>
        (null, "active" + "<br>" + "recently", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>() { activetaskBottleneckColumnOne, activetaskBottleneckColumnTwo });
        Column<Component, int> fifthHeaderColumn = new Column<Component, int>
        (null, "Task Bottlenecks", null, null,borderR:true, childrenColumns: new List<ColumnBase>()
        {
            taskBottleneckFilesColumnWrapper, activetaskBottleneckColumnWrapper
        }, description: "files changed for" + "<br>" + "many distinct tasks");

        Column<Component, long> taskPrefixesFilesColumn = new Column<Component, long>
            ("#taskPrefixesfiles", "#", null);
        Column<Component, long> taskPrefixesFilesColumnWrapper = new Column<Component, long>
        ("taskPrefixesfiles", "all" + "<br>" + "prefixes", null, null,
            childrenColumns: new List<ColumnBase>() { taskPrefixesFilesColumn });
        Column<Component, int> activetaskPrefixesColumnOne = new Column<Component, int>
            ("activetaskPrefixes#", "#", null);
        Column<Component, int> activetaskPrefixesColumnTwo = new Column<Component, int>
            ("activetaskPrefixes%all", "%all", null,borderR:true);
        Column<Component, int> activetaskPrefixesColumnWrapper = new Column<Component, int>
        (null, "recently used" + "<br>" + "prefixes", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>() { activetaskPrefixesColumnOne, activetaskPrefixesColumnTwo });
        Column<Component, int> sixthHeaderColumn = new Column<Component, int>
        (null, "Task Prefixes", null, null,borderR:true, childrenColumns: new List<ColumnBase>()
        {
            taskPrefixesFilesColumnWrapper, activetaskPrefixesColumnWrapper
        }, description: "distinct tasks prefixes" + "<br>" + "inferred from task IDs");

        Column<Component, long> concurrentActivityFilesColumn = new Column<Component, long>
            ("#concurrentActivityfiles", "#", null, null);
        Column<Component, long> concurrentActivityFilesColumnWrapper = new Column<Component, long>
        ("concurrentActivityfiles", "files", null, null,
            childrenColumns: new List<ColumnBase>() { concurrentActivityFilesColumn });
        Column<Component, int> createdConcurrentActivityColumnOne = new Column<Component, int>
            ("createdConcurrentActivity#", "#", null);
        Column<Component, int> createdConcurrentActivityColumnTwo = new Column<Component, int>
            ("createdConcurrentActivitytrend", "trend", null,borderR:true);
        Column<Component, int> createdConcurrentActivityColumnWrapper = new Column<Component, int>
        (null, "created" + "<br>" + "recently", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>()
                { createdConcurrentActivityColumnOne, createdConcurrentActivityColumnTwo });
        Column<Component, int> seventhHeaderColumn = new Column<Component, int>
        (null, "Concurrent Activity", null, null,borderR:true, childrenColumns: new List<ColumnBase>()
        {
            concurrentActivityFilesColumnWrapper, createdConcurrentActivityColumnWrapper
        }, description: "files where many" + "<br>" + "developers make" + "<br>" + "changes in same sprint");

        Column<Component, long> multiZoneActivityFilesColumn = new Column<Component, long>
            ("#multiZoneActivityfiles", "#", null);
        Column<Component, long> multiZoneActivityFilesColumnWrapper = new Column<Component, long>
        ("multiZoneActivityfiles", "files", null, null,
            childrenColumns: new List<ColumnBase>() { multiZoneActivityFilesColumn });
        Column<Component, int> createdmultiZoneActivityColumnOne = new Column<Component, int>
            ("createdmultiZoneActivity#", "#", null);
        Column<Component, int> createdmultiZoneActivityColumnTwo = new Column<Component, int>
            ("createdmultiZoneActivitytrend", "trend", null,borderR:true);
        Column<Component, int> createdmultiZoneActivityColumnWrapper = new Column<Component, int>
        (null, "created" + "<br>" + "recently", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>()
                { createdmultiZoneActivityColumnOne, createdmultiZoneActivityColumnTwo });
        Column<Component, int> eigthHeaderColumn = new Column<Component, int>
        (null, "Multi-Zone" + "<br>" + " Activity", null, null,borderR:true, childrenColumns: new List<ColumnBase>()
            {
                multiZoneActivityFilesColumnWrapper, createdmultiZoneActivityColumnWrapper
            },
            description: "files with changes from" + "<br>" + "multiple geographical" + "<br>" +
                         "regions in same sprint");

        Column<Component, long> refactoringChangesAllColumn = new Column<Component, long>
            ("%refactoringchangesall", "%", null);
        Column<Component, long> refactoringChangesAllColumnWrapper = new Column<Component, long>
        ("refactoringchangesall", "all" + "<br>" + "changes", null, null,
            childrenColumns: new List<ColumnBase>() { refactoringChangesAllColumn });
        Column<Component, int> refactoringChangesRecentColumnOne = new Column<Component, int>
            ("refactoringChangesRecent%", "%", null);
        Column<Component, int> refactoringChangesRecentColumnTwo = new Column<Component, int>
            ("refactoringChangesRecenttrend", "trend", null);
        Column<Component, int> refactoringChangesRecentColumnWrapper = new Column<Component, int>
        (null, "recent" + "<br>" + "chnges", null, null,
            childrenColumns: new List<ColumnBase>()
                { refactoringChangesRecentColumnOne, refactoringChangesRecentColumnTwo });
        Column<Component, int> ninethHeaderColumn = new Column<Component, int>
        (null, "Refactoring" + "<br>" + "Changes", null, null,
            childrenColumns: new List<ColumnBase>()
            {
                refactoringChangesAllColumnWrapper, refactoringChangesRecentColumnWrapper
            }, description: "changes reducing" + "<br>" + "sensibly a file's size");

        return new List<ColumnBase>()
        {
            firstHeaderColumn, secondHeaderColumn, thirdHeaderColumn, fourthHeaderColumn, fifthHeaderColumn,
            sixthHeaderColumn, seventhHeaderColumn, eigthHeaderColumn, ninethHeaderColumn
        };
    }
}