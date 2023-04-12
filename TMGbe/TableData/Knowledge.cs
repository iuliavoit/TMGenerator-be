using TMGbe.Models;

public class Knowledge
{
    public List<ColumnBase> getTableColumnData()
    {
        Column<Component, String> nameColumn = new Column<Component, string>
            ("component", "Component", null);
        Column<Component, String> nameColumnWrapper = new Column<Component, string>
            (null, "", null, null, childrenColumns: new List<ColumnBase>() { nameColumn });
        Column<Component, long> filesColumn = new Column<Component, long>
            ("#files", "#", null);
        Column<Component, long> filesColumnWrapper = new Column<Component, long>
            ("files", "files", null, null, childrenColumns: new List<ColumnBase>() { filesColumn });
        Column<Component, int> linesColumn = new Column<Component, int>
            ("x1000", "x1000", null);
        Column<Component, int> linesColumnWrapper = new Column<Component, int>
            ("lines", "lines", null, null, childrenColumns: new List<ColumnBase>() { linesColumn });
        Column<Component, int> commitsColumn = new Column<Component, int>
            ("#commits", "#", null);
        Column<Component, int> commitsColumnWrapper = new Column<Component, int>
            ("commits", "commits", null, null, childrenColumns: new List<ColumnBase>() { commitsColumn });
        Column<Component, int> startDateColumn = new Column<Component, int>
            ("yyyy-mmstart", "yyyy-mm", null);
        Column<Component, int> startDateColumnWrapper = new Column<Component, int>
            ("startDate", "start date", null, null, childrenColumns: new List<ColumnBase>() { startDateColumn });
        Column<Component, int> latestDateColumn = new Column<Component, int>
            ("yyyy-mmlatest", "yyyy-mm", null);
        Column<Component, int> latestDateColumnWrapper = new Column<Component, int>
            ("latestDate", "latest date", null, null, childrenColumns: new List<ColumnBase>() { latestDateColumn });
        Column<Component, int> firstHeaderColumn = new Column<Component, int>
        (null, "", null, null, childrenColumns: new List<ColumnBase>()
        {
            nameColumnWrapper, filesColumnWrapper, linesColumnWrapper, commitsColumnWrapper, startDateColumnWrapper,
            latestDateColumnWrapper
        });

        Column<Component, int> devsColumn = new Column<Component, int>
            ("#devs", "#", null);
        Column<Component, int> devsColumnWrapper = new Column<Component, int>
            ("alldevs", "all" + "<br>" + "devs", null, null, childrenColumns: new List<ColumnBase>() { devsColumn });
        Column<Component, long> activeDevsColumnOne = new Column<Component, long>
            ("#activedevs", "#", null);
        Column<Component, long> activeDevsColumnTwo = new Column<Component, long>
            ("%allactivedevs", "%all", null);
        Column<Component, long> activeDevsColumnWrapper = new Column<Component, long>
        ("activeDevs", "active" + "<br>" + "recently", null, null,
            childrenColumns: new List<ColumnBase>() { activeDevsColumnOne, activeDevsColumnTwo });
        Column<Component, long> joinedDevsColumnOne = new Column<Component, long>
            ("#joineddevs", "#", null);
        Column<Component, long> joinedDevsColumnTwo = new Column<Component, long>
            ("%alljoineddevs", "%all", null,borderR:true);
        Column<Component, long> joinedDevsColumnWrapper = new Column<Component, long>
        ("joinedDevs", "joined" + "<br>" + "recently", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>() { joinedDevsColumnOne, joinedDevsColumnTwo });
        Column<Component, int> secondHeaderColumn = new Column<Component, int>
        (null, "Developers", null, null,borderR:true, childrenColumns: new List<ColumnBase>()
        {
            devsColumnWrapper, activeDevsColumnWrapper, joinedDevsColumnWrapper
        });

        Column<Component, int> knowledgeActiveColumn = new Column<Component, int>
            ("%activeknowledge", "%", null);
        Column<Component, int> knowledgeActiveColumnWrapper = new Column<Component, int>
        ("activeknowledge", "on" + "<br>" + "$recentDate", null, null,
            childrenColumns: new List<ColumnBase>() { knowledgeActiveColumn });
        Column<Component, int> nowActiveKnowledgeColumnOne = new Column<Component, int>
            ("%nowactiveknowledge", "%", null);
        Column<Component, int> nowActiveKnowledgeColumnTwo = new Column<Component, int>
            ("trendnowactiveknowledge", "trend", null,borderR:true);
        Column<Component, int> nowActiveKnowledgeColumnWrapper = new Column<Component, int>
        ("nowactiveknowledge", "now", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>() { nowActiveKnowledgeColumnOne, nowActiveKnowledgeColumnTwo });
        Column<Component, int> thirdHeaderColumn = new Column<Component, int>
        (null, "Active Project" + "<br>" + "Knowledge", null, null,borderR:true, childrenColumns: new List<ColumnBase>()
        {
            knowledgeActiveColumnWrapper, nowActiveKnowledgeColumnWrapper
        }, description: "based on volume of change" + "<br>" + "from current developers ");

        Column<Component, long> filesWeakColumn = new Column<Component, long>
            ("#filesweak", "#", null);
        Column<Component, long> filesWeakColumnWrapper = new Column<Component, long>
            ("filesweak", "files", null, null, childrenColumns: new List<ColumnBase>() { filesWeakColumn });
        Column<Component, long> activeWeakColumnOne = new Column<Component, long>
            ("#activeweak", "#", null);
        Column<Component, long> activeWeakColumnTwo = new Column<Component, long>
            ("activeweaktrend", "trend", null,borderR:true);
        Column<Component, long> activeWeakColumnWrapper = new Column<Component, long>
        ("activeWeak", "active" + "<br>" + "recently", null, null,borderR:true,
            childrenColumns: new List<ColumnBase>() { activeWeakColumnOne, activeWeakColumnTwo });
        Column<Component, int> fourthHeaderColumn = new Column<Component, int>
        (null, "Weak" + "<br>" + "Ownership", null, null,borderR:true, childrenColumns: new List<ColumnBase>()
        {
            filesWeakColumnWrapper, activeWeakColumnWrapper
        }, description: "files where current developers" + "<br>" + "have small volume of change ");

        Column<Component, long> filesPolarisedColumn = new Column<Component, long>
            ("#filespolarised", "#", null);
        Column<Component, long> filesPolarisedColumnWrapper = new Column<Component, long>
            ("filespolarised", "files", null, null, childrenColumns: new List<ColumnBase>() { filesPolarisedColumn });
        Column<Component, long> activePolarisedColumnOne = new Column<Component, long>
            ("#activepolarised", "#", null);
        Column<Component, long> activePolarisedColumnTwo = new Column<Component, long>
            ("activepolarisedtrend", "trend", null);
        Column<Component, long> activePolarisedColumnWrapper = new Column<Component, long>
        ("activePolarised", "active" + "<br>" + "recently", null, null,
            childrenColumns: new List<ColumnBase>() { activePolarisedColumnOne, activePolarisedColumnTwo });
        Column<Component, int> fifthHeaderColumn = new Column<Component, int>
        (null, "Polarised" + "<br>" + "Ownership", null, null,
            childrenColumns: new List<ColumnBase>()
            {
                filesPolarisedColumnWrapper, activePolarisedColumnWrapper
            }, description: "files with a very few developers" + "<br>" + "doing significant work");

        return new List<ColumnBase>()
            { firstHeaderColumn, secondHeaderColumn, thirdHeaderColumn, fourthHeaderColumn, fifthHeaderColumn };
    }
}