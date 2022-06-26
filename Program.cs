using Trades.Properties;

public class Program : ITrade
{
    public double Value => throw new NotImplementedException();

    public string ClientSector => throw new NotImplementedException();

    public static void Main()
    {
        Categories categoria = new Categories();
        List<ITrade> s = new List<ITrade>();


        var sx = categoria.Trades(s);
    }
}
public class Categories : ITrade
{

    public List<ITrade> portfolio;
    public List<string> tradeCategories;

    public double Value => throw new NotImplementedException();

    public string ClientSector => throw new NotImplementedException();

    public List<string>Trades (List<ITrade> portfolio) 
    {
        var category = "";

        foreach (var element in portfolio)
        {
            if ((element.Value < 10000000) & element.ClientSector.Equals("Public"))
            {
                category = "LOWRISK";
            }
            else if ((element.Value > 10000000) & element.ClientSector.Equals("Public"))
            {
                category = "MEDIUMRISK";
            }
            else if ((element.Value > 10000000) & element.ClientSector.Equals("Private"))
            {
                category = "HIGHRISK";
            }
                        
            tradeCategories.Add(category);
        }

        return tradeCategories;
    }
}
