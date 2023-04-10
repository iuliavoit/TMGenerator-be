using TMGbe.Models;

public class ComplexityHotspots
{
       public List<ColumnBase> getComplexityHotspotsTableData()
    {
        Column<Component, String> pathColumn =
            new Column<Component, string>("fullpath", null, "Full Path", null);
        Column<Component, String> nameColumn =
            new Column<Component, string>("component", null, "Component", null);
        Column<Component, String> fileColumn =
            new Column<Component, string>("file", null, "File", null);
        Column<Component, int> sizeColumn =
            new Column<Component, int>("size", null, "Size", null);
        Column<Component, int> atcColumn =
            new Column<Component, int>("atc", null, "ATC", null);
        Column<Component, DateTime> firstChangeColumn =
            new Column<Component, DateTime>("firstChange", null, "First"+"<br>"+" Change", null);
        Column<Component, DateTime> lastChangeColumn =
            new Column<Component, DateTime>("lastChange", null, "Last"+"<br>"+"Change", null);
        Column<Component, int> allChangesColumn =
            new Column<Component, int>("allChanges", null, "All "+"<br>"+"Changes", null);
        Column<Component, int> lastYearChangesColumn =
            new Column<Component, int>("lastYearChanges", null, "Last Year "+"<br>"+"Changes", null);
        Column<Component, int> lastYearGrowthColumn =
            new Column<Component, int>("lastYearGrowth", null, "Last Year "+"<br>"+"Growth", null);
        Column<Component, int> lastYearChangeVolumeColumn =
            new Column<Component, int>("lastYearChangeVolume", null, "Last Year"+"<br>"+"Change Volume", null);
        Column<Component, int> lastYearAuthorsColumn =
            new Column<Component, int>("lastYearAuthors", null, "Last Year "+"<br>"+"Authors", null);
        Column<Component, int> pivotFileColumn =
            new Column<Component, int>("pivotFile", null, "Pivot "+"<br>"+"File", null);
        Column<Component, int> taskBottleneckColumn =
            new Column<Component, int>("taskBottleneck", null, "Task "+"<br>"+"Bottleneck", null);
        Column<Component, int> bazaarColumn =
            new Column<Component, int>("bazaar", null, "Bazaar", null);
        Column<Component, int> bugMagnetColumn =
            new Column<Component, int>("bugMagnet", null, "Bug "+"<br>"+"Magnet", null);
        Column<Component, int> weakOwnershipColumn =
            new Column<Component, int>("weakOwnership", null, "Weak"+"<br>"+" Ownership", null);
        return new List<ColumnBase>() { pathColumn, nameColumn,fileColumn, sizeColumn,atcColumn, firstChangeColumn, lastChangeColumn,allChangesColumn,
            lastYearChangesColumn,lastYearGrowthColumn, lastYearChangeVolumeColumn,lastYearAuthorsColumn, pivotFileColumn, taskBottleneckColumn, bazaarColumn, bugMagnetColumn, weakOwnershipColumn };
    }
}