using System.Collections.Generic;
using System.Text;
using Antlr4.Runtime.Tree;
using SQLParser.Parsers.TSql;

namespace SQLParser.Tests
{
    public class SqlFormatter : TSqlParserBaseListener
    {
        private const string TAB = "    ";
        StringBuilder sb=new StringBuilder();

        public string GetText()
        {
            return sb.ToString();
        }

        private bool isSubscribeNewLine = false;

        void SubscribeNewLine()
        {
            isSubscribeNewLine = true;
        }

        private bool isSubscribeSpace = false;

        void SubscribeSpace()
        {
            isSubscribeSpace = true;
        }

        void ResetSubscribe()
        {
            isSubscribeNewLine = false;
            isSubscribeSpace = false;
        }

        void ApplySubscribe()
        {
            if (isSubscribeNewLine)
            {
                AddLine();
                isSubscribeNewLine = true;
            }

            if (isSubscribeSpace)
            {
                AddSpace();
                isSubscribeSpace = false;
            }
        }

        public override void ExitTable_sources(TSqlParser.Table_sourcesContext context)
        {
            base.ExitTable_sources(context);
        }

        public override void VisitTerminal(ITerminalNode node)
        {
            
           // SubscribeSpace();

            var message = node.GetText();
            bool isAppend = true;
            
            switch (message)
            {
                case "<EOF>":
                    {
                        isAppend = false;
                        break;
                    }

                case "GROUP":
                case "HAVING":
                case "WHERE":
                    {
                        isAppend = true;
                        AddLine();
                        sb.Append(prefix);

                        break;
                    }
                case "ALL":
                case "BY":
                case "ON":
                case "AS":
                case "WITH":
                case "END":
                case "WHEN":
                    {
                        isAppend = true;
                        AddSpace();
                        break;
                    }
                case "AND":
                case "OR":
                case "ELSE":
                case "THEN":
                    {
                        isAppend = false;

                        AddSpace();
                        sb.Append(message);
                        AddSpace();

                        break;
                    }
                case ")":
                {
                    break;
                }
                case "INNER":
                case "LEFT":
                case "RIGHT":
                case "FULL":
                case "CROSS":
                case "OUTER":
                {
                    sb.Append(message);
                    AddSpace();

                    isAppend = false;

                    break;
                }
            }

            if (isAppend)
            {
                sb.Append(message);
            }

            base.VisitTerminal(node);
        }

        public class SubQueryInfo
        {
            public int pos { get; set; }
            public int level { get; set; }
        }

        private Stack<SubQueryInfo> beginSubQueryPos = new Stack<SubQueryInfo>();

        public override void EnterSubquery(TSqlParser.SubqueryContext context)
        {
            beginSubQueryPos.Push(
                new SubQueryInfo()
                {
                    pos = sb.Length + 1
                });


            base.EnterSubquery(context);
        }

        public override void ExitSubquery(TSqlParser.SubqueryContext context)
        {
            base.ExitSubquery(context);
        }

        public override void EnterAnother_statement(TSqlParser.Another_statementContext context)
        {
            isExistsQuery = true;

            base.EnterAnother_statement(context);
        }

        public override void EnterDeclare_local(TSqlParser.Declare_localContext context)
        {
            AddSpace();

            base.EnterDeclare_local(context);
        }

        public override void EnterData_type(TSqlParser.Data_typeContext context)
        {
            AddSpace();

            base.EnterData_type(context);
        }

        public override void EnterSearch_condition(TSqlParser.Search_conditionContext context)
        {
            AddSpace();

            base.EnterSearch_condition(context);
        }

        public override void EnterComparison_operator(TSqlParser.Comparison_operatorContext context)
        {
            AddSpace();

            base.EnterComparison_operator(context);
        }

        public override void ExitComparison_operator(TSqlParser.Comparison_operatorContext context)
        {
            AddSpace();

            base.EnterComparison_operator(context);
        }

        private void AddSpace()
        {
            sb.Append(" ");
        }

        private void AddLine()
        {
            sb.AppendLine();
        }
        

        private string prefix = null;
        public override void EnterQuery_specification(TSqlParser.Query_specificationContext context)
        {
            if (isExistsQuery)
            {
                AddLine();
            }
            else
            {
                isExistsQuery = true;
            }

            if (prefix.Length != 0)
            {
                sb.Append(prefix);
            }

            base.EnterQuery_specification(context);
        }

        private bool isExistsQuery = false;

        public override void EnterQuery_expression(TSqlParser.Query_expressionContext context)
        {
            base.EnterQuery_expression(context);
        }

        private bool isFirstGroupByItem = true;
        public override void EnterGroup_by_item(TSqlParser.Group_by_itemContext context)
        {
            if (isFirstGroupByItem)
            {
                AddSpace();

                isFirstGroupByItem = false;
            }
            else
            {
                AddSpace();
            }

            base.EnterGroup_by_item(context);
        }

        public override void EnterColumn_alias(TSqlParser.Column_aliasContext context)
        {
            AddSpace();

            base.EnterColumn_alias(context);
        }

        public override void EnterSql_union(TSqlParser.Sql_unionContext context)
        {
            AddLine();
            base.EnterSql_union(context);
        }

        public override void EnterAs_column_alias(TSqlParser.As_column_aliasContext context)
        {
            base.EnterAs_column_alias(context);
        }

        private bool isFirstJoin = true;
        public override void EnterJoin_part(TSqlParser.Join_partContext context)
        {
            AddLine();

            if (isFirstJoin)
            {
                AddTab();
                isFirstJoin = false;
            }

            sb.Append(prefix);

            base.EnterJoin_part(context);
        }

        public override void ExitQuery_specification(TSqlParser.Query_specificationContext context)
        {
            isFirstGroupByItem = true;
            isFirstJoin = true;

            if (prefix.Length != 0)
            {
                SubscribeNewLine();
            }

            base.ExitQuery_specification(context);
        }

        public override void ExitQuery_expression(TSqlParser.Query_expressionContext context)
        {
            
            base.ExitQuery_expression(context);
        }

        public override void EnterSelect_list(TSqlParser.Select_listContext context)
        {
            AddLine();

            base.EnterSelect_list(context);
        }

        private bool notFirstSelect_list_elem = false;
        public override void EnterSelect_list_elem(TSqlParser.Select_list_elemContext context)
        {
            if (notFirstSelect_list_elem)
            {
                AddLine();
            }
            else
            {
                notFirstSelect_list_elem = true;
                AddTab();
            }

            sb.Append(prefix);

            base.EnterSelect_list_elem(context);
        }

        private void AddTab()
        {
            prefix += prefix == null ? "" : TAB;
        }

        public override void EnterSelect_statement(TSqlParser.Select_statementContext context)
        {
            AddTab();

            base.EnterSelect_statement(context);
        }

        public override void ExitSelect_statement(TSqlParser.Select_statementContext context)
        {
            RemoveTab();

            base.ExitSelect_statement(context);
        }

        private void RemoveTab()
        {
            if (prefix.Length == 0)
            {
                prefix = null;
            }
            else
            {
                prefix = prefix.Substring(TAB.Length);
            }
        }

        public override void EnterAs_table_alias(TSqlParser.As_table_aliasContext context)
        {
            base.EnterAs_table_alias(context);
        }

        public override void EnterTable_alias(TSqlParser.Table_aliasContext context)
        {
            AddSpace();

            if (beginSubQueryPos.Count==0
                ||!isExistsQuery)
            {
                return;
            }

            var info = beginSubQueryPos.Pop();

            sb.Insert(info.pos, "\r\n---------'" + context.GetText() + "'-------- " + beginSubQueryPos.Count + "\r\n");
            

            base.EnterTable_alias(context);
        }


        public override void ExitSelect_list(TSqlParser.Select_listContext context)
        {
            notFirstSelect_list_elem = false;
            RemoveTab();

            AddLine();
            sb.Append(prefix);

            base.ExitSelect_list(context);
        }

        public override void EnterTable_source(TSqlParser.Table_sourceContext context)
        {
            AddSpace();
            base.EnterTable_source(context);
        }
    }
}