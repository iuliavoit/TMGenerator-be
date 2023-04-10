using TMGbe.Models;

public class QualityAssuranceRagCriti
{
    public List<ColumnBase> getQualityAssuranceRagCritiTableData()
    {
        Column<Component, String> nameColumn =
            new Column<Component, string>("component", null, "Component", null);
        Column<Component, String> firstHeaderColumn =
            new Column<Component, string>(null, null, "", null, new List<ColumnBase>() { nameColumn });
        
        Column<Component, int> allFilesCriticalColumn =
            new Column<Component, int>("allFilescritical", null, "all files", null);
        Column<Component, int> locCriticalColumn=
            new Column<Component, int>("loccritical", null, "LOC", null);
        Column<Component, int> secondHeaderColumn = new Column<Component, int>(null, null, "Critical Files", null,
            new List<ColumnBase>()
            {
                allFilesCriticalColumn, locCriticalColumn
            }/*, description:"only large frequently changing "+"<br>"+"Java non-test files"*/);

        Column<Component, int> testedFilesCriticalColumn =
            new Column<Component, int>("testedFilescritical", null, "tested" + "<br>" + "files", null);
        Column<Component, int>locFilesCriticalRefColumn =
            new Column<Component, int>("locFilesCriticalRefColumn", null, "LOC", null);
        Column<Component, int>referencesFilesCriticalRefColumn =
            new Column<Component, int>("referencesFilesCriticalRefColumn", null, "#"+"<br>"+"references", null);
        Column<Component, int> thirdHeaderColumn = new Column<Component, int>(null, null, "Critical Files", null,
            new List<ColumnBase>()
            {
                testedFilesCriticalColumn, locFilesCriticalRefColumn, referencesFilesCriticalRefColumn
            }/*, description:"only large frequently changing "+"<br>"+"functional Java files"*/);
        
        Column<Component, int>referencesFileStatisticsColumn =
            new Column<Component, int>("referencesFileStatisticsColumn", null, "references/file", null);
        Column<Component, int>filesWithReferencesStatisticsColumn =
            new Column<Component, int>("filesWithReferencesStatisticsColumn", null, "% files w. "+"<br>"+"references", null);
        Column<Component, int>locFilesWithReferencesStatisticsColumn =
            new Column<Component, int>("locFilesWithReferencesStatisticsColumn", null, "% LOC of files"+"<br>"+"w. references", null);
        Column<Component, int> fourthHeaderColumn = new Column<Component, int>(null, null, "Statistics", null,
            new List<ColumnBase>()
            {
                referencesFileStatisticsColumn, filesWithReferencesStatisticsColumn, locFilesWithReferencesStatisticsColumn
            }/*, description:"coverage ratios"*/);
        
        return new List<ColumnBase>()
        {
            firstHeaderColumn, secondHeaderColumn, thirdHeaderColumn, fourthHeaderColumn
        };
    }
}