using System;
using System.Collections.Generic;
using System.Text;

public class QueryBuilder
{
    private string _select;
    private string _from;
    private string _where;
    private string _orderBy;

    public QueryBuilder Select(string columns)
    {
        _select = columns;
        return this; 
    }

    public QueryBuilder From(string table)
    {
        _from = table;
        return this;
    }

    public QueryBuilder Where(string condition)
    {
        _where = condition;
        return this;
    }

    public QueryBuilder OrderBy(string column)
    {
        _orderBy = column;
        return this;
    }

    public string Build()
    {
        StringBuilder query = new StringBuilder();

        query.Append($"SELECT {_select} FROM {_from}");

        if (_where != null)
        {
            query.Append($" WHERE {_where}");
        }

        if (_orderBy != null)
        {
            query.Append($" ORDER BY {_orderBy}");
        }

        query.Append($"\n");
        return query.ToString();
    }
}