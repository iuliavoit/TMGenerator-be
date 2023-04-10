using TMGbe.Models;

public class QualityAssuranceRagAll
{
    public List<ColumnBase> getQualityAssuranceRagAllTableData()
    {
        Column<Component, String> nameColumn =
            new Column<Component, string>("component", null, "Component", null);
        Column<Component, String> firstHeaderColumn =
            new Column<Component, string>(null, null, "", null, new List<ColumnBase>() { nameColumn });
        Column<Component, int> allFilesTestableColumn =
            new Column<Component, int>("allFilestestable", null, "all files", null);
        Column<Component, int> locTestableColumn=
            new Column<Component, int>("loctestable", null, "LOC", null);
        Column<Component, int> secondHeaderColumn = new Column<Component, int>(null, null, "Testable Files", null,
            new List<ColumnBase>()
            {
                allFilesTestableColumn, locTestableColumn
            }/*, description:"only functional Java files"*/);
        Column<Component, int> filesRefColumn =
            new Column<Component, int>("allFilesred", null, "files", null);
        Column<Component, int> locRefColumn=
            new Column<Component, int>("locref", null, "LOC", null);
        Column<Component, int> referencesColumn=
            new Column<Component, int>("references", null, "references", null);
        Column<Component, int> thirdHeaderColumn = new Column<Component, int>(null, null, "Files with References from Test Code ", null,
            new List<ColumnBase>()
            {
                filesRefColumn, locRefColumn,referencesColumn
            }/*, description:"only functional Java files"*/);
        
        Column<Component, int>refFileStatisticsColumn=
            new Column<Component, int>("reffilestatistics", null, "ref/file", null);
        Column<Component, int>filesWithRefStatisticsColumn=
            new Column<Component, int>("fileswitrefstatistics", null, "% files w. ref", null);
        Column<Component, int>locStatisticsColumn=
            new Column<Component, int>("locstatistics", null, "% LOC", null);
        Column<Component, int>fourthHeaderColumn = new Column<Component, int>(null, null, "Statistics", null,
            new List<ColumnBase>()
            {
                refFileStatisticsColumn, filesWithRefStatisticsColumn,locStatisticsColumn
            }/*, description:"coverage ratios"*/);
        
        return new List<ColumnBase>()
        {
            firstHeaderColumn, secondHeaderColumn, thirdHeaderColumn, fourthHeaderColumn
        };

    }
}