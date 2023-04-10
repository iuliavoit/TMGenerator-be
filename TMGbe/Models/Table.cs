using Newtonsoft.Json;

namespace TMGbe.Models;

public class Table<T>
{
    public string name;
    public List<ColumnBase> columns;

    private QualityAssuranceRagAll ch = new QualityAssuranceRagAll();

    public Table(string name, List<ColumnBase>? columns)
    {
        this.name = name;
        this.columns = ch.getQualityAssuranceRagAllTableData();
    }
    
    
    public  string GenerateJsonFromTable(Table<Component> table)
    {
        var settings = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            Formatting = Formatting.Indented
        };
        return JsonConvert.SerializeObject(table.columns, settings);
    }
    
    private static List<object> ProcessColumns(List<ColumnBase> columns)
    {
        var outputColumns = new List<object>();

        foreach (var column in columns)
        {
            if (column is Column<Component, int> intColumn)
            {
                outputColumns.Add(CreateColumnObject(intColumn));
            }
            else if (column is Column<Component, long> longColumn)
            {
                outputColumns.Add(CreateColumnObject(longColumn));
            }
            else if (column is Column<Component, string> stringColumn)
            {
                outputColumns.Add(CreateColumnObject(stringColumn));
            }
        }

        return outputColumns;
    }
    
    private static object CreateColumnObject<T>(Column<Component, T> column)
    {
        return new
        {
            name = column.name,
            id = column.id,
            sortable = column.sortable,
            type = typeof(T).Name,
            childrenColumns = ProcessColumns(column.childrenColumns)
        };
    }
}