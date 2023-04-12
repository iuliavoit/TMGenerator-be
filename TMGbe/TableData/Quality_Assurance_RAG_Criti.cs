using TMGbe.Models;

public class QualityAssuranceRagCriti
{
    public List<ColumnBase> getTableColumnData()
    {
        Column<Component, String> nameColumn = new Column<Component, string>
            ("component", "Component", null);
        Column<Component, String> firstHeaderColumn = new Column<Component, string>
            (null, "", null, null, childrenColumns: new List<ColumnBase>() { nameColumn });

        Column<Component, int> allFilesCriticalColumn = new Column<Component, int>
            ("allFilescritical", "all files", null);
        Column<Component, int> locCriticalColumn = new Column<Component, int>
            ("loccritical", "LOC", null, null);
        Column<Component, int> secondHeaderColumn = new Column<Component, int>
        (null, "Critical Files", null, null,borderB:true, childrenColumns: new List<ColumnBase>()
        {
            allFilesCriticalColumn, locCriticalColumn
        }, description: "only large frequently changing " + "<br>" + "Java non-test files");

        Column<Component, int> testedFilesCriticalColumn = new Column<Component, int>
            ("testedFilescritical", "tested" + "<br>" + "files", null);
        Column<Component, int> locFilesCriticalRefColumn = new Column<Component, int>
            ("locFilesCriticalRefColumn", "LOC", null);
        Column<Component, int> referencesFilesCriticalRefColumn = new Column<Component, int>
            ("referencesFilesCriticalRefColumn", "#" + "<br>" + "references", null);
        Column<Component, int> thirdHeaderColumn = new Column<Component, int>
        (null, "Critical Files", null, null, borderB:true,childrenColumns: new List<ColumnBase>()
        {
            testedFilesCriticalColumn, locFilesCriticalRefColumn, referencesFilesCriticalRefColumn
        }, description: "only large frequently changing " + "<br>" + "functional Java files");

        Column<Component, int> referencesFileStatisticsColumn = new Column<Component, int>
            ("referencesFileStatisticsColumn", "references/file", null);
        Column<Component, int> filesWithReferencesStatisticsColumn = new Column<Component, int>
            ("filesWithReferencesStatisticsColumn", "% files w. " + "<br>" + "references", null);
        Column<Component, int> locFilesWithReferencesStatisticsColumn = new Column<Component, int>
            ("locFilesWithReferencesStatisticsColumn", "% LOC of files" + "<br>" + "w. references", null);
        Column<Component, int> fourthHeaderColumn = new Column<Component, int>
        (null, "Statistics", null, null,borderB:true, childrenColumns: new List<ColumnBase>()
        {
            referencesFileStatisticsColumn, filesWithReferencesStatisticsColumn,
            locFilesWithReferencesStatisticsColumn
        }, description: "coverage ratios");

        return new List<ColumnBase>()
        {
            firstHeaderColumn, secondHeaderColumn, thirdHeaderColumn, fourthHeaderColumn
        };
    }
}