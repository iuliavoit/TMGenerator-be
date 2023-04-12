using TMGbe.Models;

public class QualityAssuranceRagAll
{
    public List<ColumnBase> getTableColumnData()
    {
        Column<Component, String> nameColumn = new Column<Component, string>
            ("component", "Component", null);
        Column<Component, String> firstHeaderColumn = new Column<Component, string>
            (null, "", null, null, childrenColumns: new List<ColumnBase>() { nameColumn });
        Column<Component, int> allFilesTestableColumn = new Column<Component, int>
            ("allFilestestable", "all files", null);
        Column<Component, int> locTestableColumn = new Column<Component, int>
            ("loctestable", "LOC", null);
        Column<Component, int> secondHeaderColumn = new Column<Component, int>
        (null, "Testable Files", null, null, borderB:true,childrenColumns: new List<ColumnBase>()
        {
            allFilesTestableColumn, locTestableColumn
        }, description: "only functional Java files");
        Column<Component, int> filesRefColumn = new Column<Component, int>
            ("allFilesred", "files", null);
        Column<Component, int> locRefColumn = new Column<Component, int>
            ("locref", "LOC", null, null);
        Column<Component, int> referencesColumn = new Column<Component, int>
            ("references", "references", null, null);
        Column<Component, int> thirdHeaderColumn = new Column<Component, int>
        (null, "Files with References from Test Code ", null, null,borderB:true, childrenColumns: new List<ColumnBase>()
        {
            filesRefColumn, locRefColumn, referencesColumn
        }, description: "only functional Java files");

        Column<Component, int> refFileStatisticsColumn = new Column<Component, int>
            ("reffilestatistics", "ref/file", null);
        Column<Component, int> filesWithRefStatisticsColumn = new Column<Component, int>
            ("fileswitrefstatistics", "% files w. ref", null);
        Column<Component, int> locStatisticsColumn = new Column<Component, int>
            ("locstatistics", "% LOC", null);
        Column<Component, int> fourthHeaderColumn = new Column<Component, int>
        (null, "Statistics", null, null, borderB:true, childrenColumns: new List<ColumnBase>()
        {
            refFileStatisticsColumn, filesWithRefStatisticsColumn, locStatisticsColumn
        }, description: "coverage ratios");

        return new List<ColumnBase>()
        {
            firstHeaderColumn, secondHeaderColumn, thirdHeaderColumn, fourthHeaderColumn
        };
    }
}