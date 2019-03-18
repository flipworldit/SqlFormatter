using System.Diagnostics;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using SQLParser.Parsers.TSql;

namespace SQLParser.Tests
{
    public class SqlTraceVisiter : ITSqlParserListener
    {
        private bool _isViewExit = true;

        public SqlTraceVisiter()
        {
        }

        public SqlTraceVisiter(bool isViewExit)
        {
            _isViewExit = isViewExit;
        }

        public void VisitTerminal(ITerminalNode node)
        {
            Debug.WriteLine("VisitTerminal = " + node.GetText());

        }

        public void VisitErrorNode(IErrorNode node)
        {
            Debug.WriteLine("VisitErrorNode = " + node.GetText());
        }

        public void EnterEveryRule(ParserRuleContext ctx)
        {
            Debug.WriteLine("EnterEveryRule = " + ctx.GetText());
        }

        public void ExitEveryRule(ParserRuleContext ctx)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitEveryRule = " + ctx.GetText());
            }
        }

        public void EnterTsql_file(TSqlParser.Tsql_fileContext context)
        {
            Debug.WriteLine("EnterTsql_file = " + context.GetText());
        }

        public void ExitTsql_file(TSqlParser.Tsql_fileContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitTsql_file = " + context.GetText());
            }
        }

        public void EnterBatch(TSqlParser.BatchContext context)
        {
            Debug.WriteLine("EnterBatch = " + context.GetText());
        }

        public void ExitBatch(TSqlParser.BatchContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitBatch = " + context.GetText());
            }
        }

        public void EnterSql_clauses(TSqlParser.Sql_clausesContext context)
        {
            Debug.WriteLine("EnterSql_clauses = " + context.GetText());
        }

        public void ExitSql_clauses(TSqlParser.Sql_clausesContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSql_clauses = " + context.GetText());
            }
        }

        public void EnterSql_clause(TSqlParser.Sql_clauseContext context)
        {
            Debug.WriteLine("EnterSql_clause = " + context.GetText());
        }

        public void ExitSql_clause(TSqlParser.Sql_clauseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSql_clause = " + context.GetText());
            }
        }

        public void EnterDml_clause(TSqlParser.Dml_clauseContext context)
        {
            Debug.WriteLine("EnterDml_clause = " + context.GetText());
        }

        public void ExitDml_clause(TSqlParser.Dml_clauseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDml_clause = " + context.GetText());
            }
        }

        public void EnterDdl_clause(TSqlParser.Ddl_clauseContext context)
        {
            Debug.WriteLine("EnterDdl_clause = " + context.GetText());
        }

        public void ExitDdl_clause(TSqlParser.Ddl_clauseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDdl_clause = " + context.GetText());
            }
        }

        public void EnterBackup_statement(TSqlParser.Backup_statementContext context)
        {
            Debug.WriteLine("EnterBackup_statement = " + context.GetText());
        }

        public void ExitBackup_statement(TSqlParser.Backup_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitBackup_statement = " + context.GetText());
            }
        }

        public void EnterCfl_statement(TSqlParser.Cfl_statementContext context)
        {
            Debug.WriteLine("EnterCfl_statement = " + context.GetText());
        }

        public void ExitCfl_statement(TSqlParser.Cfl_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCfl_statement = " + context.GetText());
            }
        }

        public void EnterBlock_statement(TSqlParser.Block_statementContext context)
        {
            Debug.WriteLine("EnterBlock_statement = " + context.GetText());
        }

        public void ExitBlock_statement(TSqlParser.Block_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitBlock_statement = " + context.GetText());
            }
        }

        public void EnterBreak_statement(TSqlParser.Break_statementContext context)
        {
            Debug.WriteLine("EnterBreak_statement = " + context.GetText());
        }

        public void ExitBreak_statement(TSqlParser.Break_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitBreak_statement = " + context.GetText());
            }
        }

        public void EnterContinue_statement(TSqlParser.Continue_statementContext context)
        {
            Debug.WriteLine("EnterContinue_statement = " + context.GetText());
        }

        public void ExitContinue_statement(TSqlParser.Continue_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitContinue_statement = " + context.GetText());
            }
        }

        public void EnterGoto_statement(TSqlParser.Goto_statementContext context)
        {
            Debug.WriteLine("EnterGoto_statement = " + context.GetText());
        }

        public void ExitGoto_statement(TSqlParser.Goto_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitGoto_statement = " + context.GetText());
            }
        }

        public void EnterReturn_statement(TSqlParser.Return_statementContext context)
        {
            Debug.WriteLine("EnterReturn_statement = " + context.GetText());
        }

        public void ExitReturn_statement(TSqlParser.Return_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitReturn_statement = " + context.GetText());
            }
        }

        public void EnterIf_statement(TSqlParser.If_statementContext context)
        {
            Debug.WriteLine("EnterIf_statement = " + context.GetText());
        }

        public void ExitIf_statement(TSqlParser.If_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitIf_statement = " + context.GetText());
            }
        }

        public void EnterThrow_statement(TSqlParser.Throw_statementContext context)
        {
            Debug.WriteLine("EnterThrow_statement = " + context.GetText());
        }

        public void ExitThrow_statement(TSqlParser.Throw_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitThrow_statement = " + context.GetText());
            }
        }

        public void EnterThrow_error_number(TSqlParser.Throw_error_numberContext context)
        {
            Debug.WriteLine("EnterThrow_error_number = " + context.GetText());
        }

        public void ExitThrow_error_number(TSqlParser.Throw_error_numberContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitThrow_error_number = " + context.GetText());
            }
        }

        public void EnterThrow_message(TSqlParser.Throw_messageContext context)
        {
            Debug.WriteLine("EnterThrow_message = " + context.GetText());
        }

        public void ExitThrow_message(TSqlParser.Throw_messageContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitThrow_message = " + context.GetText());
            }
        }

        public void EnterThrow_state(TSqlParser.Throw_stateContext context)
        {
            Debug.WriteLine("EnterThrow_state = " + context.GetText());
        }

        public void ExitThrow_state(TSqlParser.Throw_stateContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitThrow_state = " + context.GetText());
            }
        }

        public void EnterTry_catch_statement(TSqlParser.Try_catch_statementContext context)
        {
            Debug.WriteLine("EnterTry_catch_statement = " + context.GetText());
        }

        public void ExitTry_catch_statement(TSqlParser.Try_catch_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitTry_catch_statement = " + context.GetText());
            }
        }

        public void EnterWaitfor_statement(TSqlParser.Waitfor_statementContext context)
        {
            Debug.WriteLine("EnterWaitfor_statement = " + context.GetText());
        }

        public void ExitWaitfor_statement(TSqlParser.Waitfor_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitWaitfor_statement = " + context.GetText());
            }
        }

        public void EnterWhile_statement(TSqlParser.While_statementContext context)
        {
            Debug.WriteLine("EnterWhile_statement = " + context.GetText());
        }

        public void ExitWhile_statement(TSqlParser.While_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitWhile_statement = " + context.GetText());
            }
        }

        public void EnterPrint_statement(TSqlParser.Print_statementContext context)
        {
            Debug.WriteLine("EnterPrint_statement = " + context.GetText());
        }

        public void ExitPrint_statement(TSqlParser.Print_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitPrint_statement = " + context.GetText());
            }
        }

        public void EnterRaiseerror_statement(TSqlParser.Raiseerror_statementContext context)
        {
            Debug.WriteLine("EnterRaiseerror_statement = " + context.GetText());
        }

        public void ExitRaiseerror_statement(TSqlParser.Raiseerror_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitRaiseerror_statement = " + context.GetText());
            }
        }

        public void EnterEmpty_statement(TSqlParser.Empty_statementContext context)
        {
            Debug.WriteLine("EnterEmpty_statement = " + context.GetText());
        }

        public void ExitEmpty_statement(TSqlParser.Empty_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitEmpty_statement = " + context.GetText());
            }
        }

        public void EnterAnother_statement(TSqlParser.Another_statementContext context)
        {
            Debug.WriteLine("EnterAnother_statement = " + context.GetText());
        }

        public void ExitAnother_statement(TSqlParser.Another_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAnother_statement = " + context.GetText());
            }
        }

        public void EnterAlter_application_role(TSqlParser.Alter_application_roleContext context)
        {
            Debug.WriteLine("EnterAlter_application_role = " + context.GetText());
        }

        public void ExitAlter_application_role(TSqlParser.Alter_application_roleContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_application_role = " + context.GetText());
            }
        }

        public void EnterCreate_application_role(TSqlParser.Create_application_roleContext context)
        {
            Debug.WriteLine("EnterCreate_application_role = " + context.GetText());
        }

        public void ExitCreate_application_role(TSqlParser.Create_application_roleContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_application_role = " + context.GetText());
            }
        }

        public void EnterDrop_aggregate(TSqlParser.Drop_aggregateContext context)
        {
            Debug.WriteLine("EnterDrop_aggregate = " + context.GetText());
        }

        public void ExitDrop_aggregate(TSqlParser.Drop_aggregateContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_aggregate = " + context.GetText());
            }
        }

        public void EnterDrop_application_role(TSqlParser.Drop_application_roleContext context)
        {
            Debug.WriteLine("EnterDrop_application_role = " + context.GetText());
        }

        public void ExitDrop_application_role(TSqlParser.Drop_application_roleContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_application_role = " + context.GetText());
            }
        }

        public void EnterAlter_assembly(TSqlParser.Alter_assemblyContext context)
        {
            Debug.WriteLine("EnterAlter_assembly = " + context.GetText());
        }

        public void ExitAlter_assembly(TSqlParser.Alter_assemblyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_assembly = " + context.GetText());
            }
        }

        public void EnterAlter_assembly_start(TSqlParser.Alter_assembly_startContext context)
        {
            Debug.WriteLine("EnterAlter_assembly_start = " + context.GetText());
        }

        public void ExitAlter_assembly_start(TSqlParser.Alter_assembly_startContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_assembly_start = " + context.GetText());
            }
        }

        public void EnterAlter_assembly_clause(TSqlParser.Alter_assembly_clauseContext context)
        {
            Debug.WriteLine("EnterAlter_assembly_clause = " + context.GetText());
        }

        public void ExitAlter_assembly_clause(TSqlParser.Alter_assembly_clauseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_assembly_clause = " + context.GetText());
            }
        }

        public void EnterAlter_assembly_from_clause(TSqlParser.Alter_assembly_from_clauseContext context)
        {
            Debug.WriteLine("EnterAlter_assembly_from_clause = " + context.GetText());
        }

        public void ExitAlter_assembly_from_clause(TSqlParser.Alter_assembly_from_clauseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_assembly_from_clause = " + context.GetText());
            }
        }

        public void EnterAlter_assembly_from_clause_start(TSqlParser.Alter_assembly_from_clause_startContext context)
        {
            Debug.WriteLine("EnterAlter_assembly_from_clause_start = " + context.GetText());
        }

        public void ExitAlter_assembly_from_clause_start(TSqlParser.Alter_assembly_from_clause_startContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_assembly_from_clause_start = " + context.GetText());
            }
        }

        public void EnterAlter_assembly_drop_clause(TSqlParser.Alter_assembly_drop_clauseContext context)
        {
            Debug.WriteLine("EnterAlter_assembly_drop_clause = " + context.GetText());
        }

        public void ExitAlter_assembly_drop_clause(TSqlParser.Alter_assembly_drop_clauseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_assembly_drop_clause = " + context.GetText());
            }
        }

        public void EnterAlter_assembly_drop_multiple_files(TSqlParser.Alter_assembly_drop_multiple_filesContext context)
        {
            Debug.WriteLine("EnterAlter_assembly_drop_multiple_files = " + context.GetText());
        }

        public void ExitAlter_assembly_drop_multiple_files(TSqlParser.Alter_assembly_drop_multiple_filesContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_assembly_drop_multiple_files = " + context.GetText());
            }
        }

        public void EnterAlter_assembly_drop(TSqlParser.Alter_assembly_dropContext context)
        {
            Debug.WriteLine("EnterAlter_assembly_drop = " + context.GetText());
        }

        public void ExitAlter_assembly_drop(TSqlParser.Alter_assembly_dropContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_assembly_drop = " + context.GetText());
            }
        }

        public void EnterAlter_assembly_add_clause(TSqlParser.Alter_assembly_add_clauseContext context)
        {
            Debug.WriteLine("EnterAlter_assembly_add_clause = " + context.GetText());
        }

        public void ExitAlter_assembly_add_clause(TSqlParser.Alter_assembly_add_clauseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_assembly_add_clause = " + context.GetText());
            }
        }

        public void EnterAlter_asssembly_add_clause_start(TSqlParser.Alter_asssembly_add_clause_startContext context)
        {
            Debug.WriteLine("EnterAlter_asssembly_add_clause_start = " + context.GetText());
        }

        public void ExitAlter_asssembly_add_clause_start(TSqlParser.Alter_asssembly_add_clause_startContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_asssembly_add_clause_start = " + context.GetText());
            }
        }

        public void EnterAlter_assembly_client_file_clause(TSqlParser.Alter_assembly_client_file_clauseContext context)
        {
            Debug.WriteLine("EnterAlter_assembly_client_file_clause = " + context.GetText());
        }

        public void ExitAlter_assembly_client_file_clause(TSqlParser.Alter_assembly_client_file_clauseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_assembly_client_file_clause = " + context.GetText());
            }
        }

        public void EnterAlter_assembly_file_name(TSqlParser.Alter_assembly_file_nameContext context)
        {
            Debug.WriteLine("EnterAlter_assembly_file_name = " + context.GetText());
        }

        public void ExitAlter_assembly_file_name(TSqlParser.Alter_assembly_file_nameContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_assembly_file_name = " + context.GetText());
            }
        }

        public void EnterAlter_assembly_file_bits(TSqlParser.Alter_assembly_file_bitsContext context)
        {
            Debug.WriteLine("EnterAlter_assembly_file_bits = " + context.GetText());
        }

        public void ExitAlter_assembly_file_bits(TSqlParser.Alter_assembly_file_bitsContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_assembly_file_bits = " + context.GetText());
            }
        }

        public void EnterAlter_assembly_as(TSqlParser.Alter_assembly_asContext context)
        {
            Debug.WriteLine("EnterAlter_assembly_as = " + context.GetText());
        }

        public void ExitAlter_assembly_as(TSqlParser.Alter_assembly_asContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_assembly_as = " + context.GetText());
            }
        }

        public void EnterAlter_assembly_with_clause(TSqlParser.Alter_assembly_with_clauseContext context)
        {
            Debug.WriteLine("EnterAlter_assembly_with_clause = " + context.GetText());
        }

        public void ExitAlter_assembly_with_clause(TSqlParser.Alter_assembly_with_clauseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_assembly_with_clause = " + context.GetText());
            }
        }

        public void EnterAlter_assembly_with(TSqlParser.Alter_assembly_withContext context)
        {
            Debug.WriteLine("EnterAlter_assembly_with = " + context.GetText());
        }

        public void ExitAlter_assembly_with(TSqlParser.Alter_assembly_withContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_assembly_with = " + context.GetText());
            }
        }

        public void EnterClient_assembly_specifier(TSqlParser.Client_assembly_specifierContext context)
        {
            Debug.WriteLine("EnterClient_assembly_specifier = " + context.GetText());
        }

        public void ExitClient_assembly_specifier(TSqlParser.Client_assembly_specifierContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitClient_assembly_specifier = " + context.GetText());
            }
        }

        public void EnterAssembly_option(TSqlParser.Assembly_optionContext context)
        {
            Debug.WriteLine("EnterAssembly_option = " + context.GetText());
        }

        public void ExitAssembly_option(TSqlParser.Assembly_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAssembly_option = " + context.GetText());
            }
        }

        public void EnterNetwork_file_share(TSqlParser.Network_file_shareContext context)
        {
            Debug.WriteLine("EnterNetwork_file_share = " + context.GetText());
        }

        public void ExitNetwork_file_share(TSqlParser.Network_file_shareContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitNetwork_file_share = " + context.GetText());
            }
        }

        public void EnterNetwork_computer(TSqlParser.Network_computerContext context)
        {
            Debug.WriteLine("EnterNetwork_computer = " + context.GetText());
        }

        public void ExitNetwork_computer(TSqlParser.Network_computerContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitNetwork_computer = " + context.GetText());
            }
        }

        public void EnterNetwork_file_start(TSqlParser.Network_file_startContext context)
        {
            Debug.WriteLine("EnterNetwork_file_start = " + context.GetText());
        }

        public void ExitNetwork_file_start(TSqlParser.Network_file_startContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitNetwork_file_start = " + context.GetText());
            }
        }

        public void EnterFile_path(TSqlParser.File_pathContext context)
        {
            Debug.WriteLine("EnterFile_path = " + context.GetText());
        }

        public void ExitFile_path(TSqlParser.File_pathContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitFile_path = " + context.GetText());
            }
        }

        public void EnterFile_directory_path_separator(TSqlParser.File_directory_path_separatorContext context)
        {
            Debug.WriteLine("EnterFile_directory_path_separator = " + context.GetText());
        }

        public void ExitFile_directory_path_separator(TSqlParser.File_directory_path_separatorContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitFile_directory_path_separator = " + context.GetText());
            }
        }

        public void EnterLocal_file(TSqlParser.Local_fileContext context)
        {
            Debug.WriteLine("EnterLocal_file = " + context.GetText());
        }

        public void ExitLocal_file(TSqlParser.Local_fileContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitLocal_file = " + context.GetText());
            }
        }

        public void EnterLocal_drive(TSqlParser.Local_driveContext context)
        {
            Debug.WriteLine("EnterLocal_drive = " + context.GetText());
        }

        public void ExitLocal_drive(TSqlParser.Local_driveContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitLocal_drive = " + context.GetText());
            }
        }

        public void EnterMultiple_local_files(TSqlParser.Multiple_local_filesContext context)
        {
            Debug.WriteLine("EnterMultiple_local_files = " + context.GetText());
        }

        public void ExitMultiple_local_files(TSqlParser.Multiple_local_filesContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitMultiple_local_files = " + context.GetText());
            }
        }

        public void EnterMultiple_local_file_start(TSqlParser.Multiple_local_file_startContext context)
        {
            Debug.WriteLine("EnterMultiple_local_file_start = " + context.GetText());
        }

        public void ExitMultiple_local_file_start(TSqlParser.Multiple_local_file_startContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitMultiple_local_file_start = " + context.GetText());
            }
        }

        public void EnterCreate_assembly(TSqlParser.Create_assemblyContext context)
        {
            Debug.WriteLine("EnterCreate_assembly = " + context.GetText());
        }

        public void ExitCreate_assembly(TSqlParser.Create_assemblyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_assembly = " + context.GetText());
            }
        }

        public void EnterDrop_assembly(TSqlParser.Drop_assemblyContext context)
        {
            Debug.WriteLine("EnterDrop_assembly = " + context.GetText());
        }

        public void ExitDrop_assembly(TSqlParser.Drop_assemblyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_assembly = " + context.GetText());
            }
        }

        public void EnterAlter_asymmetric_key(TSqlParser.Alter_asymmetric_keyContext context)
        {
            Debug.WriteLine("EnterAlter_asymmetric_key = " + context.GetText());
        }

        public void ExitAlter_asymmetric_key(TSqlParser.Alter_asymmetric_keyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_asymmetric_key = " + context.GetText());
            }
        }

        public void EnterAlter_asymmetric_key_start(TSqlParser.Alter_asymmetric_key_startContext context)
        {
            Debug.WriteLine("EnterAlter_asymmetric_key_start = " + context.GetText());
        }

        public void ExitAlter_asymmetric_key_start(TSqlParser.Alter_asymmetric_key_startContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_asymmetric_key_start = " + context.GetText());
            }
        }

        public void EnterAsymmetric_key_option(TSqlParser.Asymmetric_key_optionContext context)
        {
            Debug.WriteLine("EnterAsymmetric_key_option = " + context.GetText());
        }

        public void ExitAsymmetric_key_option(TSqlParser.Asymmetric_key_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAsymmetric_key_option = " + context.GetText());
            }
        }

        public void EnterAsymmetric_key_option_start(TSqlParser.Asymmetric_key_option_startContext context)
        {
            Debug.WriteLine("EnterAsymmetric_key_option_start = " + context.GetText());
        }

        public void ExitAsymmetric_key_option_start(TSqlParser.Asymmetric_key_option_startContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAsymmetric_key_option_start = " + context.GetText());
            }
        }

        public void EnterAsymmetric_key_password_change_option(
            TSqlParser.Asymmetric_key_password_change_optionContext context)
        {
            Debug.WriteLine("EnterAsymmetric_key_password_change_option = " + context.GetText());
        }

        public void ExitAsymmetric_key_password_change_option(
            TSqlParser.Asymmetric_key_password_change_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAsymmetric_key_password_change_option = " + context.GetText());
            }
        }

        public void EnterCreate_asymmetric_key(TSqlParser.Create_asymmetric_keyContext context)
        {
            Debug.WriteLine("EnterCreate_asymmetric_key = " + context.GetText());
        }

        public void ExitCreate_asymmetric_key(TSqlParser.Create_asymmetric_keyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_asymmetric_key = " + context.GetText());
            }
        }

        public void EnterDrop_asymmetric_key(TSqlParser.Drop_asymmetric_keyContext context)
        {
            Debug.WriteLine("EnterDrop_asymmetric_key = " + context.GetText());
        }

        public void ExitDrop_asymmetric_key(TSqlParser.Drop_asymmetric_keyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_asymmetric_key = " + context.GetText());
            }
        }

        public void EnterAlter_authorization(TSqlParser.Alter_authorizationContext context)
        {
            Debug.WriteLine("EnterAlter_authorization = " + context.GetText());
        }

        public void ExitAlter_authorization(TSqlParser.Alter_authorizationContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_authorization = " + context.GetText());
            }
        }

        public void EnterAuthorization_grantee(TSqlParser.Authorization_granteeContext context)
        {
            Debug.WriteLine("EnterAuthorization_grantee = " + context.GetText());
        }

        public void ExitAuthorization_grantee(TSqlParser.Authorization_granteeContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAuthorization_grantee = " + context.GetText());
            }
        }

        public void EnterEntity_to(TSqlParser.Entity_toContext context)
        {
            Debug.WriteLine("EnterEntity_to = " + context.GetText());
        }

        public void ExitEntity_to(TSqlParser.Entity_toContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitEntity_to = " + context.GetText());
            }
        }

        public void EnterColon_colon(TSqlParser.Colon_colonContext context)
        {
            Debug.WriteLine("EnterColon_colon = " + context.GetText());
        }

        public void ExitColon_colon(TSqlParser.Colon_colonContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitColon_colon = " + context.GetText());
            }
        }

        public void EnterAlter_authorization_start(TSqlParser.Alter_authorization_startContext context)
        {
            Debug.WriteLine("EnterAlter_authorization_start = " + context.GetText());
        }

        public void ExitAlter_authorization_start(TSqlParser.Alter_authorization_startContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_authorization_start = " + context.GetText());
            }
        }

        public void EnterAlter_authorization_for_sql_database(
            TSqlParser.Alter_authorization_for_sql_databaseContext context)
        {
            Debug.WriteLine("EnterAlter_authorization_for_sql_database = " + context.GetText());
        }

        public void ExitAlter_authorization_for_sql_database(
            TSqlParser.Alter_authorization_for_sql_databaseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_authorization_for_sql_database = " + context.GetText());
            }
        }

        public void EnterAlter_authorization_for_azure_dw(TSqlParser.Alter_authorization_for_azure_dwContext context)
        {
            Debug.WriteLine("EnterAlter_authorization_for_azure_dw = " + context.GetText());
        }

        public void ExitAlter_authorization_for_azure_dw(TSqlParser.Alter_authorization_for_azure_dwContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_authorization_for_azure_dw = " + context.GetText());
            }
        }

        public void EnterAlter_authorization_for_parallel_dw(
            TSqlParser.Alter_authorization_for_parallel_dwContext context)
        {
            Debug.WriteLine("EnterAlter_authorization_for_parallel_dw = " + context.GetText());
        }

        public void ExitAlter_authorization_for_parallel_dw(
            TSqlParser.Alter_authorization_for_parallel_dwContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_authorization_for_parallel_dw = " + context.GetText());
            }
        }

        public void EnterClass_type(TSqlParser.Class_typeContext context)
        {
            Debug.WriteLine("EnterClass_type = " + context.GetText());
        }

        public void ExitClass_type(TSqlParser.Class_typeContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitClass_type = " + context.GetText());
            }
        }

        public void EnterClass_type_for_sql_database(TSqlParser.Class_type_for_sql_databaseContext context)
        {
            Debug.WriteLine("EnterClass_type_for_sql_database = " + context.GetText());
        }

        public void ExitClass_type_for_sql_database(TSqlParser.Class_type_for_sql_databaseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitClass_type_for_sql_database = " + context.GetText());
            }
        }

        public void EnterClass_type_for_azure_dw(TSqlParser.Class_type_for_azure_dwContext context)
        {
            Debug.WriteLine("EnterClass_type_for_azure_dw = " + context.GetText());
        }

        public void ExitClass_type_for_azure_dw(TSqlParser.Class_type_for_azure_dwContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitClass_type_for_azure_dw = " + context.GetText());
            }
        }

        public void EnterClass_type_for_parallel_dw(TSqlParser.Class_type_for_parallel_dwContext context)
        {
            Debug.WriteLine("EnterClass_type_for_parallel_dw = " + context.GetText());
        }

        public void ExitClass_type_for_parallel_dw(TSqlParser.Class_type_for_parallel_dwContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitClass_type_for_parallel_dw = " + context.GetText());
            }
        }

        public void EnterDrop_availability_group(TSqlParser.Drop_availability_groupContext context)
        {
            Debug.WriteLine("EnterDrop_availability_group = " + context.GetText());
        }

        public void ExitDrop_availability_group(TSqlParser.Drop_availability_groupContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_availability_group = " + context.GetText());
            }
        }

        public void EnterAlter_availability_group(TSqlParser.Alter_availability_groupContext context)
        {
            Debug.WriteLine("EnterAlter_availability_group = " + context.GetText());
        }

        public void ExitAlter_availability_group(TSqlParser.Alter_availability_groupContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_availability_group = " + context.GetText());
            }
        }

        public void EnterAlter_availability_group_start(TSqlParser.Alter_availability_group_startContext context)
        {
            Debug.WriteLine("EnterAlter_availability_group_start = " + context.GetText());
        }

        public void ExitAlter_availability_group_start(TSqlParser.Alter_availability_group_startContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_availability_group_start = " + context.GetText());
            }
        }

        public void EnterAlter_availability_group_options(TSqlParser.Alter_availability_group_optionsContext context)
        {
            Debug.WriteLine("EnterAlter_availability_group_options = " + context.GetText());
        }

        public void ExitAlter_availability_group_options(TSqlParser.Alter_availability_group_optionsContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_availability_group_options = " + context.GetText());
            }
        }

        public void EnterCreate_or_alter_broker_priority(TSqlParser.Create_or_alter_broker_priorityContext context)
        {
            Debug.WriteLine("EnterCreate_or_alter_broker_priority = " + context.GetText());
        }

        public void ExitCreate_or_alter_broker_priority(TSqlParser.Create_or_alter_broker_priorityContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_or_alter_broker_priority = " + context.GetText());
            }
        }

        public void EnterDrop_broker_priority(TSqlParser.Drop_broker_priorityContext context)
        {
            Debug.WriteLine("EnterDrop_broker_priority = " + context.GetText());
        }

        public void ExitDrop_broker_priority(TSqlParser.Drop_broker_priorityContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_broker_priority = " + context.GetText());
            }
        }

        public void EnterAlter_certificate(TSqlParser.Alter_certificateContext context)
        {
            Debug.WriteLine("EnterAlter_certificate = " + context.GetText());
        }

        public void ExitAlter_certificate(TSqlParser.Alter_certificateContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_certificate = " + context.GetText());
            }
        }

        public void EnterAlter_column_encryption_key(TSqlParser.Alter_column_encryption_keyContext context)
        {
            Debug.WriteLine("EnterAlter_column_encryption_key = " + context.GetText());
        }

        public void ExitAlter_column_encryption_key(TSqlParser.Alter_column_encryption_keyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_column_encryption_key = " + context.GetText());
            }
        }

        public void EnterCreate_column_encryption_key(TSqlParser.Create_column_encryption_keyContext context)
        {
            Debug.WriteLine("EnterCreate_column_encryption_key = " + context.GetText());
        }

        public void ExitCreate_column_encryption_key(TSqlParser.Create_column_encryption_keyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_column_encryption_key = " + context.GetText());
            }
        }

        public void EnterDrop_certificate(TSqlParser.Drop_certificateContext context)
        {
            Debug.WriteLine("EnterDrop_certificate = " + context.GetText());
        }

        public void ExitDrop_certificate(TSqlParser.Drop_certificateContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_certificate = " + context.GetText());
            }
        }

        public void EnterDrop_column_encryption_key(TSqlParser.Drop_column_encryption_keyContext context)
        {
            Debug.WriteLine("EnterDrop_column_encryption_key = " + context.GetText());
        }

        public void ExitDrop_column_encryption_key(TSqlParser.Drop_column_encryption_keyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_column_encryption_key = " + context.GetText());
            }
        }

        public void EnterDrop_column_master_key(TSqlParser.Drop_column_master_keyContext context)
        {
            Debug.WriteLine("EnterDrop_column_master_key = " + context.GetText());
        }

        public void ExitDrop_column_master_key(TSqlParser.Drop_column_master_keyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_column_master_key = " + context.GetText());
            }
        }

        public void EnterDrop_contract(TSqlParser.Drop_contractContext context)
        {
            Debug.WriteLine("EnterDrop_contract = " + context.GetText());
        }

        public void ExitDrop_contract(TSqlParser.Drop_contractContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_contract = " + context.GetText());
            }
        }

        public void EnterDrop_credential(TSqlParser.Drop_credentialContext context)
        {
            Debug.WriteLine("EnterDrop_credential = " + context.GetText());
        }

        public void ExitDrop_credential(TSqlParser.Drop_credentialContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_credential = " + context.GetText());
            }
        }

        public void EnterDrop_cryptograhic_provider(TSqlParser.Drop_cryptograhic_providerContext context)
        {
            Debug.WriteLine("EnterDrop_cryptograhic_provider = " + context.GetText());
        }

        public void ExitDrop_cryptograhic_provider(TSqlParser.Drop_cryptograhic_providerContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_cryptograhic_provider = " + context.GetText());
            }
        }

        public void EnterDrop_database(TSqlParser.Drop_databaseContext context)
        {
            Debug.WriteLine("EnterDrop_database = " + context.GetText());
        }

        public void ExitDrop_database(TSqlParser.Drop_databaseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_database = " + context.GetText());
            }
        }

        public void EnterDrop_database_audit_specification(TSqlParser.Drop_database_audit_specificationContext context)
        {
            Debug.WriteLine("EnterDrop_database_audit_specification = " + context.GetText());
        }

        public void ExitDrop_database_audit_specification(TSqlParser.Drop_database_audit_specificationContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_database_audit_specification = " + context.GetText());
            }
        }

        public void EnterDrop_database_scoped_credential(TSqlParser.Drop_database_scoped_credentialContext context)
        {
            Debug.WriteLine("EnterDrop_database_scoped_credential = " + context.GetText());
        }

        public void ExitDrop_database_scoped_credential(TSqlParser.Drop_database_scoped_credentialContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_database_scoped_credential = " + context.GetText());
            }
        }

        public void EnterDrop_default(TSqlParser.Drop_defaultContext context)
        {
            Debug.WriteLine("EnterDrop_default = " + context.GetText());
        }

        public void ExitDrop_default(TSqlParser.Drop_defaultContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_default = " + context.GetText());
            }
        }

        public void EnterDrop_endpoint(TSqlParser.Drop_endpointContext context)
        {
            Debug.WriteLine("EnterDrop_endpoint = " + context.GetText());
        }

        public void ExitDrop_endpoint(TSqlParser.Drop_endpointContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_endpoint = " + context.GetText());
            }
        }

        public void EnterDrop_external_data_source(TSqlParser.Drop_external_data_sourceContext context)
        {
            Debug.WriteLine("EnterDrop_external_data_source = " + context.GetText());
        }

        public void ExitDrop_external_data_source(TSqlParser.Drop_external_data_sourceContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_external_data_source = " + context.GetText());
            }
        }

        public void EnterDrop_external_file_format(TSqlParser.Drop_external_file_formatContext context)
        {
            Debug.WriteLine("EnterDrop_external_file_format = " + context.GetText());
        }

        public void ExitDrop_external_file_format(TSqlParser.Drop_external_file_formatContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_external_file_format = " + context.GetText());
            }
        }

        public void EnterDrop_external_library(TSqlParser.Drop_external_libraryContext context)
        {
            Debug.WriteLine("EnterDrop_external_library = " + context.GetText());
        }

        public void ExitDrop_external_library(TSqlParser.Drop_external_libraryContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_external_library = " + context.GetText());
            }
        }

        public void EnterDrop_external_resource_pool(TSqlParser.Drop_external_resource_poolContext context)
        {
            Debug.WriteLine("EnterDrop_external_resource_pool = " + context.GetText());
        }

        public void ExitDrop_external_resource_pool(TSqlParser.Drop_external_resource_poolContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_external_resource_pool = " + context.GetText());
            }
        }

        public void EnterDrop_external_table(TSqlParser.Drop_external_tableContext context)
        {
            Debug.WriteLine("EnterDrop_external_table = " + context.GetText());
        }

        public void ExitDrop_external_table(TSqlParser.Drop_external_tableContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_external_table = " + context.GetText());
            }
        }

        public void EnterDrop_event_notifications(TSqlParser.Drop_event_notificationsContext context)
        {
            Debug.WriteLine("EnterDrop_event_notifications = " + context.GetText());
        }

        public void ExitDrop_event_notifications(TSqlParser.Drop_event_notificationsContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_event_notifications = " + context.GetText());
            }
        }

        public void EnterDrop_event_session(TSqlParser.Drop_event_sessionContext context)
        {
            Debug.WriteLine("EnterDrop_event_session = " + context.GetText());
        }

        public void ExitDrop_event_session(TSqlParser.Drop_event_sessionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_event_session = " + context.GetText());
            }
        }

        public void EnterDrop_fulltext_catalog(TSqlParser.Drop_fulltext_catalogContext context)
        {
            Debug.WriteLine("EnterDrop_fulltext_catalog = " + context.GetText());
        }

        public void ExitDrop_fulltext_catalog(TSqlParser.Drop_fulltext_catalogContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_fulltext_catalog = " + context.GetText());
            }
        }

        public void EnterDrop_fulltext_index(TSqlParser.Drop_fulltext_indexContext context)
        {
            Debug.WriteLine("EnterDrop_fulltext_index = " + context.GetText());
        }

        public void ExitDrop_fulltext_index(TSqlParser.Drop_fulltext_indexContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_fulltext_index = " + context.GetText());
            }
        }

        public void EnterDrop_fulltext_stoplist(TSqlParser.Drop_fulltext_stoplistContext context)
        {
            Debug.WriteLine("EnterDrop_fulltext_stoplist = " + context.GetText());
        }

        public void ExitDrop_fulltext_stoplist(TSqlParser.Drop_fulltext_stoplistContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_fulltext_stoplist = " + context.GetText());
            }
        }

        public void EnterDrop_login(TSqlParser.Drop_loginContext context)
        {
            Debug.WriteLine("EnterDrop_login = " + context.GetText());
        }

        public void ExitDrop_login(TSqlParser.Drop_loginContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_login = " + context.GetText());
            }
        }

        public void EnterDrop_master_key(TSqlParser.Drop_master_keyContext context)
        {
            Debug.WriteLine("EnterDrop_master_key = " + context.GetText());
        }

        public void ExitDrop_master_key(TSqlParser.Drop_master_keyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_master_key = " + context.GetText());
            }
        }

        public void EnterDrop_message_type(TSqlParser.Drop_message_typeContext context)
        {
            Debug.WriteLine("EnterDrop_message_type = " + context.GetText());
        }

        public void ExitDrop_message_type(TSqlParser.Drop_message_typeContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_message_type = " + context.GetText());
            }
        }

        public void EnterDrop_partition_function(TSqlParser.Drop_partition_functionContext context)
        {
            Debug.WriteLine("EnterDrop_partition_function = " + context.GetText());
        }

        public void ExitDrop_partition_function(TSqlParser.Drop_partition_functionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_partition_function = " + context.GetText());
            }
        }

        public void EnterDrop_partition_scheme(TSqlParser.Drop_partition_schemeContext context)
        {
            Debug.WriteLine("EnterDrop_partition_scheme = " + context.GetText());
        }

        public void ExitDrop_partition_scheme(TSqlParser.Drop_partition_schemeContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_partition_scheme = " + context.GetText());
            }
        }

        public void EnterDrop_queue(TSqlParser.Drop_queueContext context)
        {
            Debug.WriteLine("EnterDrop_queue = " + context.GetText());
        }

        public void ExitDrop_queue(TSqlParser.Drop_queueContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_queue = " + context.GetText());
            }
        }

        public void EnterDrop_remote_service_binding(TSqlParser.Drop_remote_service_bindingContext context)
        {
            Debug.WriteLine("EnterDrop_remote_service_binding = " + context.GetText());
        }

        public void ExitDrop_remote_service_binding(TSqlParser.Drop_remote_service_bindingContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_remote_service_binding = " + context.GetText());
            }
        }

        public void EnterDrop_resource_pool(TSqlParser.Drop_resource_poolContext context)
        {
            Debug.WriteLine("EnterDrop_resource_pool = " + context.GetText());
        }

        public void ExitDrop_resource_pool(TSqlParser.Drop_resource_poolContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_resource_pool = " + context.GetText());
            }
        }

        public void EnterDrop_db_role(TSqlParser.Drop_db_roleContext context)
        {
            Debug.WriteLine("EnterDrop_db_role = " + context.GetText());
        }

        public void ExitDrop_db_role(TSqlParser.Drop_db_roleContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_db_role = " + context.GetText());
            }
        }

        public void EnterDrop_route(TSqlParser.Drop_routeContext context)
        {
            Debug.WriteLine("EnterDrop_route = " + context.GetText());
        }

        public void ExitDrop_route(TSqlParser.Drop_routeContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_route = " + context.GetText());
            }
        }

        public void EnterDrop_rule(TSqlParser.Drop_ruleContext context)
        {
            Debug.WriteLine("EnterDrop_rule = " + context.GetText());
        }

        public void ExitDrop_rule(TSqlParser.Drop_ruleContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_rule = " + context.GetText());
            }
        }

        public void EnterDrop_schema(TSqlParser.Drop_schemaContext context)
        {
            Debug.WriteLine("EnterDrop_schema = " + context.GetText());
        }

        public void ExitDrop_schema(TSqlParser.Drop_schemaContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_schema = " + context.GetText());
            }
        }

        public void EnterDrop_search_property_list(TSqlParser.Drop_search_property_listContext context)
        {
            Debug.WriteLine("EnterDrop_search_property_list = " + context.GetText());
        }

        public void ExitDrop_search_property_list(TSqlParser.Drop_search_property_listContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_search_property_list = " + context.GetText());
            }
        }

        public void EnterDrop_security_policy(TSqlParser.Drop_security_policyContext context)
        {
            Debug.WriteLine("EnterDrop_security_policy = " + context.GetText());
        }

        public void ExitDrop_security_policy(TSqlParser.Drop_security_policyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_security_policy = " + context.GetText());
            }
        }

        public void EnterDrop_sequence(TSqlParser.Drop_sequenceContext context)
        {
            Debug.WriteLine("EnterDrop_sequence = " + context.GetText());
        }

        public void ExitDrop_sequence(TSqlParser.Drop_sequenceContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_sequence = " + context.GetText());
            }
        }

        public void EnterDrop_server_audit(TSqlParser.Drop_server_auditContext context)
        {
            Debug.WriteLine("EnterDrop_server_audit = " + context.GetText());
        }

        public void ExitDrop_server_audit(TSqlParser.Drop_server_auditContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_server_audit = " + context.GetText());
            }
        }

        public void EnterDrop_server_audit_specification(TSqlParser.Drop_server_audit_specificationContext context)
        {
            Debug.WriteLine("EnterDrop_server_audit_specification = " + context.GetText());
        }

        public void ExitDrop_server_audit_specification(TSqlParser.Drop_server_audit_specificationContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_server_audit_specification = " + context.GetText());
            }
        }

        public void EnterDrop_server_role(TSqlParser.Drop_server_roleContext context)
        {
            Debug.WriteLine("EnterDrop_server_role = " + context.GetText());
        }

        public void ExitDrop_server_role(TSqlParser.Drop_server_roleContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_server_role = " + context.GetText());
            }
        }

        public void EnterDrop_service(TSqlParser.Drop_serviceContext context)
        {
            Debug.WriteLine("EnterDrop_service = " + context.GetText());
        }

        public void ExitDrop_service(TSqlParser.Drop_serviceContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_service = " + context.GetText());
            }
        }

        public void EnterDrop_signature(TSqlParser.Drop_signatureContext context)
        {
            Debug.WriteLine("EnterDrop_signature = " + context.GetText());
        }

        public void ExitDrop_signature(TSqlParser.Drop_signatureContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_signature = " + context.GetText());
            }
        }

        public void EnterDrop_statistics_name_azure_dw_and_pdw(
            TSqlParser.Drop_statistics_name_azure_dw_and_pdwContext context)
        {
            Debug.WriteLine("EnterDrop_statistics_name_azure_dw_and_pdw = " + context.GetText());
        }

        public void ExitDrop_statistics_name_azure_dw_and_pdw(
            TSqlParser.Drop_statistics_name_azure_dw_and_pdwContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_statistics_name_azure_dw_and_pdw = " + context.GetText());
            }
        }

        public void EnterDrop_symmetric_key(TSqlParser.Drop_symmetric_keyContext context)
        {
            Debug.WriteLine("EnterDrop_symmetric_key = " + context.GetText());
        }

        public void ExitDrop_symmetric_key(TSqlParser.Drop_symmetric_keyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_symmetric_key = " + context.GetText());
            }
        }

        public void EnterDrop_synonym(TSqlParser.Drop_synonymContext context)
        {
            Debug.WriteLine("EnterDrop_synonym = " + context.GetText());
        }

        public void ExitDrop_synonym(TSqlParser.Drop_synonymContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_synonym = " + context.GetText());
            }
        }

        public void EnterDrop_user(TSqlParser.Drop_userContext context)
        {
            Debug.WriteLine("EnterDrop_user = " + context.GetText());
        }

        public void ExitDrop_user(TSqlParser.Drop_userContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_user = " + context.GetText());
            }
        }

        public void EnterDrop_workload_group(TSqlParser.Drop_workload_groupContext context)
        {
            Debug.WriteLine("EnterDrop_workload_group = " + context.GetText());
        }

        public void ExitDrop_workload_group(TSqlParser.Drop_workload_groupContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_workload_group = " + context.GetText());
            }
        }

        public void EnterDrop_xml_schema_collection(TSqlParser.Drop_xml_schema_collectionContext context)
        {
            Debug.WriteLine("EnterDrop_xml_schema_collection = " + context.GetText());
        }

        public void ExitDrop_xml_schema_collection(TSqlParser.Drop_xml_schema_collectionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_xml_schema_collection = " + context.GetText());
            }
        }

        public void EnterDisable_trigger(TSqlParser.Disable_triggerContext context)
        {
            Debug.WriteLine("EnterDisable_trigger = " + context.GetText());
        }

        public void ExitDisable_trigger(TSqlParser.Disable_triggerContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDisable_trigger = " + context.GetText());
            }
        }

        public void EnterEnable_trigger(TSqlParser.Enable_triggerContext context)
        {
            Debug.WriteLine("EnterEnable_trigger = " + context.GetText());
        }

        public void ExitEnable_trigger(TSqlParser.Enable_triggerContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitEnable_trigger = " + context.GetText());
            }
        }

        public void EnterTruncate_table(TSqlParser.Truncate_tableContext context)
        {
            Debug.WriteLine("EnterTruncate_table = " + context.GetText());
        }

        public void ExitTruncate_table(TSqlParser.Truncate_tableContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitTruncate_table = " + context.GetText());
            }
        }

        public void EnterCreate_column_master_key(TSqlParser.Create_column_master_keyContext context)
        {
            Debug.WriteLine("EnterCreate_column_master_key = " + context.GetText());
        }

        public void ExitCreate_column_master_key(TSqlParser.Create_column_master_keyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_column_master_key = " + context.GetText());
            }
        }

        public void EnterAlter_credential(TSqlParser.Alter_credentialContext context)
        {
            Debug.WriteLine("EnterAlter_credential = " + context.GetText());
        }

        public void ExitAlter_credential(TSqlParser.Alter_credentialContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_credential = " + context.GetText());
            }
        }

        public void EnterCreate_credential(TSqlParser.Create_credentialContext context)
        {
            Debug.WriteLine("EnterCreate_credential = " + context.GetText());
        }

        public void ExitCreate_credential(TSqlParser.Create_credentialContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_credential = " + context.GetText());
            }
        }

        public void EnterAlter_cryptographic_provider(TSqlParser.Alter_cryptographic_providerContext context)
        {
            Debug.WriteLine("EnterAlter_cryptographic_provider = " + context.GetText());
        }

        public void ExitAlter_cryptographic_provider(TSqlParser.Alter_cryptographic_providerContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_cryptographic_provider = " + context.GetText());
            }
        }

        public void EnterCreate_cryptographic_provider(TSqlParser.Create_cryptographic_providerContext context)
        {
            Debug.WriteLine("EnterCreate_cryptographic_provider = " + context.GetText());
        }

        public void ExitCreate_cryptographic_provider(TSqlParser.Create_cryptographic_providerContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_cryptographic_provider = " + context.GetText());
            }
        }

        public void EnterCreate_event_notification(TSqlParser.Create_event_notificationContext context)
        {
            Debug.WriteLine("EnterCreate_event_notification = " + context.GetText());
        }

        public void ExitCreate_event_notification(TSqlParser.Create_event_notificationContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_event_notification = " + context.GetText());
            }
        }

        public void EnterCreate_or_alter_event_session(TSqlParser.Create_or_alter_event_sessionContext context)
        {
            Debug.WriteLine("EnterCreate_or_alter_event_session = " + context.GetText());
        }

        public void ExitCreate_or_alter_event_session(TSqlParser.Create_or_alter_event_sessionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_or_alter_event_session = " + context.GetText());
            }
        }

        public void EnterEvent_session_predicate_expression(TSqlParser.Event_session_predicate_expressionContext context)
        {
            Debug.WriteLine("EnterEvent_session_predicate_expression = " + context.GetText());
        }

        public void ExitEvent_session_predicate_expression(TSqlParser.Event_session_predicate_expressionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitEvent_session_predicate_expression = " + context.GetText());
            }
        }

        public void EnterEvent_session_predicate_factor(TSqlParser.Event_session_predicate_factorContext context)
        {
            Debug.WriteLine("EnterEvent_session_predicate_factor = " + context.GetText());
        }

        public void ExitEvent_session_predicate_factor(TSqlParser.Event_session_predicate_factorContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitEvent_session_predicate_factor = " + context.GetText());
            }
        }

        public void EnterEvent_session_predicate_leaf(TSqlParser.Event_session_predicate_leafContext context)
        {
            Debug.WriteLine("EnterEvent_session_predicate_leaf = " + context.GetText());
        }

        public void ExitEvent_session_predicate_leaf(TSqlParser.Event_session_predicate_leafContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitEvent_session_predicate_leaf = " + context.GetText());
            }
        }

        public void EnterAlter_external_data_source(TSqlParser.Alter_external_data_sourceContext context)
        {
            Debug.WriteLine("EnterAlter_external_data_source = " + context.GetText());
        }

        public void ExitAlter_external_data_source(TSqlParser.Alter_external_data_sourceContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_external_data_source = " + context.GetText());
            }
        }

        public void EnterAlter_external_library(TSqlParser.Alter_external_libraryContext context)
        {
            Debug.WriteLine("EnterAlter_external_library = " + context.GetText());
        }

        public void ExitAlter_external_library(TSqlParser.Alter_external_libraryContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_external_library = " + context.GetText());
            }
        }

        public void EnterCreate_external_library(TSqlParser.Create_external_libraryContext context)
        {
            Debug.WriteLine("EnterCreate_external_library = " + context.GetText());
        }

        public void ExitCreate_external_library(TSqlParser.Create_external_libraryContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_external_library = " + context.GetText());
            }
        }

        public void EnterAlter_external_resource_pool(TSqlParser.Alter_external_resource_poolContext context)
        {
            Debug.WriteLine("EnterAlter_external_resource_pool = " + context.GetText());
        }

        public void ExitAlter_external_resource_pool(TSqlParser.Alter_external_resource_poolContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_external_resource_pool = " + context.GetText());
            }
        }

        public void EnterCreate_external_resource_pool(TSqlParser.Create_external_resource_poolContext context)
        {
            Debug.WriteLine("EnterCreate_external_resource_pool = " + context.GetText());
        }

        public void ExitCreate_external_resource_pool(TSqlParser.Create_external_resource_poolContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_external_resource_pool = " + context.GetText());
            }
        }

        public void EnterAlter_fulltext_catalog(TSqlParser.Alter_fulltext_catalogContext context)
        {
            Debug.WriteLine("EnterAlter_fulltext_catalog = " + context.GetText());
        }

        public void ExitAlter_fulltext_catalog(TSqlParser.Alter_fulltext_catalogContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_fulltext_catalog = " + context.GetText());
            }
        }

        public void EnterCreate_fulltext_catalog(TSqlParser.Create_fulltext_catalogContext context)
        {
            Debug.WriteLine("EnterCreate_fulltext_catalog = " + context.GetText());
        }

        public void ExitCreate_fulltext_catalog(TSqlParser.Create_fulltext_catalogContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_fulltext_catalog = " + context.GetText());
            }
        }

        public void EnterAlter_fulltext_stoplist(TSqlParser.Alter_fulltext_stoplistContext context)
        {
            Debug.WriteLine("EnterAlter_fulltext_stoplist = " + context.GetText());
        }

        public void ExitAlter_fulltext_stoplist(TSqlParser.Alter_fulltext_stoplistContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_fulltext_stoplist = " + context.GetText());
            }
        }

        public void EnterCreate_fulltext_stoplist(TSqlParser.Create_fulltext_stoplistContext context)
        {
            Debug.WriteLine("EnterCreate_fulltext_stoplist = " + context.GetText());
        }

        public void ExitCreate_fulltext_stoplist(TSqlParser.Create_fulltext_stoplistContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_fulltext_stoplist = " + context.GetText());
            }
        }

        public void EnterAlter_login_sql_server(TSqlParser.Alter_login_sql_serverContext context)
        {
            Debug.WriteLine("EnterAlter_login_sql_server = " + context.GetText());
        }

        public void ExitAlter_login_sql_server(TSqlParser.Alter_login_sql_serverContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_login_sql_server = " + context.GetText());
            }
        }

        public void EnterCreate_login_sql_server(TSqlParser.Create_login_sql_serverContext context)
        {
            Debug.WriteLine("EnterCreate_login_sql_server = " + context.GetText());
        }

        public void ExitCreate_login_sql_server(TSqlParser.Create_login_sql_serverContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_login_sql_server = " + context.GetText());
            }
        }

        public void EnterAlter_login_azure_sql(TSqlParser.Alter_login_azure_sqlContext context)
        {
            Debug.WriteLine("EnterAlter_login_azure_sql = " + context.GetText());
        }

        public void ExitAlter_login_azure_sql(TSqlParser.Alter_login_azure_sqlContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_login_azure_sql = " + context.GetText());
            }
        }

        public void EnterCreate_login_azure_sql(TSqlParser.Create_login_azure_sqlContext context)
        {
            Debug.WriteLine("EnterCreate_login_azure_sql = " + context.GetText());
        }

        public void ExitCreate_login_azure_sql(TSqlParser.Create_login_azure_sqlContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_login_azure_sql = " + context.GetText());
            }
        }

        public void EnterAlter_login_azure_sql_dw_and_pdw(TSqlParser.Alter_login_azure_sql_dw_and_pdwContext context)
        {
            Debug.WriteLine("EnterAlter_login_azure_sql_dw_and_pdw = " + context.GetText());
        }

        public void ExitAlter_login_azure_sql_dw_and_pdw(TSqlParser.Alter_login_azure_sql_dw_and_pdwContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_login_azure_sql_dw_and_pdw = " + context.GetText());
            }
        }

        public void EnterCreate_login_pdw(TSqlParser.Create_login_pdwContext context)
        {
            Debug.WriteLine("EnterCreate_login_pdw = " + context.GetText());
        }

        public void ExitCreate_login_pdw(TSqlParser.Create_login_pdwContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_login_pdw = " + context.GetText());
            }
        }

        public void EnterAlter_master_key_sql_server(TSqlParser.Alter_master_key_sql_serverContext context)
        {
            Debug.WriteLine("EnterAlter_master_key_sql_server = " + context.GetText());
        }

        public void ExitAlter_master_key_sql_server(TSqlParser.Alter_master_key_sql_serverContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_master_key_sql_server = " + context.GetText());
            }
        }

        public void EnterCreate_master_key_sql_server(TSqlParser.Create_master_key_sql_serverContext context)
        {
            Debug.WriteLine("EnterCreate_master_key_sql_server = " + context.GetText());
        }

        public void ExitCreate_master_key_sql_server(TSqlParser.Create_master_key_sql_serverContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_master_key_sql_server = " + context.GetText());
            }
        }

        public void EnterAlter_master_key_azure_sql(TSqlParser.Alter_master_key_azure_sqlContext context)
        {
            Debug.WriteLine("EnterAlter_master_key_azure_sql = " + context.GetText());
        }

        public void ExitAlter_master_key_azure_sql(TSqlParser.Alter_master_key_azure_sqlContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_master_key_azure_sql = " + context.GetText());
            }
        }

        public void EnterCreate_master_key_azure_sql(TSqlParser.Create_master_key_azure_sqlContext context)
        {
            Debug.WriteLine("EnterCreate_master_key_azure_sql = " + context.GetText());
        }

        public void ExitCreate_master_key_azure_sql(TSqlParser.Create_master_key_azure_sqlContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_master_key_azure_sql = " + context.GetText());
            }
        }

        public void EnterAlter_message_type(TSqlParser.Alter_message_typeContext context)
        {
            Debug.WriteLine("EnterAlter_message_type = " + context.GetText());
        }

        public void ExitAlter_message_type(TSqlParser.Alter_message_typeContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_message_type = " + context.GetText());
            }
        }

        public void EnterAlter_partition_function(TSqlParser.Alter_partition_functionContext context)
        {
            Debug.WriteLine("EnterAlter_partition_function = " + context.GetText());
        }

        public void ExitAlter_partition_function(TSqlParser.Alter_partition_functionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_partition_function = " + context.GetText());
            }
        }

        public void EnterAlter_partition_scheme(TSqlParser.Alter_partition_schemeContext context)
        {
            Debug.WriteLine("EnterAlter_partition_scheme = " + context.GetText());
        }

        public void ExitAlter_partition_scheme(TSqlParser.Alter_partition_schemeContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_partition_scheme = " + context.GetText());
            }
        }

        public void EnterAlter_remote_service_binding(TSqlParser.Alter_remote_service_bindingContext context)
        {
            Debug.WriteLine("EnterAlter_remote_service_binding = " + context.GetText());
        }

        public void ExitAlter_remote_service_binding(TSqlParser.Alter_remote_service_bindingContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_remote_service_binding = " + context.GetText());
            }
        }

        public void EnterCreate_remote_service_binding(TSqlParser.Create_remote_service_bindingContext context)
        {
            Debug.WriteLine("EnterCreate_remote_service_binding = " + context.GetText());
        }

        public void ExitCreate_remote_service_binding(TSqlParser.Create_remote_service_bindingContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_remote_service_binding = " + context.GetText());
            }
        }

        public void EnterCreate_resource_pool(TSqlParser.Create_resource_poolContext context)
        {
            Debug.WriteLine("EnterCreate_resource_pool = " + context.GetText());
        }

        public void ExitCreate_resource_pool(TSqlParser.Create_resource_poolContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_resource_pool = " + context.GetText());
            }
        }

        public void EnterAlter_resource_governor(TSqlParser.Alter_resource_governorContext context)
        {
            Debug.WriteLine("EnterAlter_resource_governor = " + context.GetText());
        }

        public void ExitAlter_resource_governor(TSqlParser.Alter_resource_governorContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_resource_governor = " + context.GetText());
            }
        }

        public void EnterAlter_db_role(TSqlParser.Alter_db_roleContext context)
        {
            Debug.WriteLine("EnterAlter_db_role = " + context.GetText());
        }

        public void ExitAlter_db_role(TSqlParser.Alter_db_roleContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_db_role = " + context.GetText());
            }
        }

        public void EnterCreate_db_role(TSqlParser.Create_db_roleContext context)
        {
            Debug.WriteLine("EnterCreate_db_role = " + context.GetText());
        }

        public void ExitCreate_db_role(TSqlParser.Create_db_roleContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_db_role = " + context.GetText());
            }
        }

        public void EnterCreate_route(TSqlParser.Create_routeContext context)
        {
            Debug.WriteLine("EnterCreate_route = " + context.GetText());
        }

        public void ExitCreate_route(TSqlParser.Create_routeContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_route = " + context.GetText());
            }
        }

        public void EnterCreate_rule(TSqlParser.Create_ruleContext context)
        {
            Debug.WriteLine("EnterCreate_rule = " + context.GetText());
        }

        public void ExitCreate_rule(TSqlParser.Create_ruleContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_rule = " + context.GetText());
            }
        }

        public void EnterAlter_schema_sql(TSqlParser.Alter_schema_sqlContext context)
        {
            Debug.WriteLine("EnterAlter_schema_sql = " + context.GetText());
        }

        public void ExitAlter_schema_sql(TSqlParser.Alter_schema_sqlContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_schema_sql = " + context.GetText());
            }
        }

        public void EnterCreate_schema(TSqlParser.Create_schemaContext context)
        {
            Debug.WriteLine("EnterCreate_schema = " + context.GetText());
        }

        public void ExitCreate_schema(TSqlParser.Create_schemaContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_schema = " + context.GetText());
            }
        }

        public void EnterCreate_schema_azure_sql_dw_and_pdw(TSqlParser.Create_schema_azure_sql_dw_and_pdwContext context)
        {
            Debug.WriteLine("EnterCreate_schema_azure_sql_dw_and_pdw = " + context.GetText());
        }

        public void ExitCreate_schema_azure_sql_dw_and_pdw(TSqlParser.Create_schema_azure_sql_dw_and_pdwContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_schema_azure_sql_dw_and_pdw = " + context.GetText());
            }
        }

        public void EnterAlter_schema_azure_sql_dw_and_pdw(TSqlParser.Alter_schema_azure_sql_dw_and_pdwContext context)
        {
            Debug.WriteLine("EnterAlter_schema_azure_sql_dw_and_pdw = " + context.GetText());
        }

        public void ExitAlter_schema_azure_sql_dw_and_pdw(TSqlParser.Alter_schema_azure_sql_dw_and_pdwContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_schema_azure_sql_dw_and_pdw = " + context.GetText());
            }
        }

        public void EnterCreate_search_property_list(TSqlParser.Create_search_property_listContext context)
        {
            Debug.WriteLine("EnterCreate_search_property_list = " + context.GetText());
        }

        public void ExitCreate_search_property_list(TSqlParser.Create_search_property_listContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_search_property_list = " + context.GetText());
            }
        }

        public void EnterCreate_security_policy(TSqlParser.Create_security_policyContext context)
        {
            Debug.WriteLine("EnterCreate_security_policy = " + context.GetText());
        }

        public void ExitCreate_security_policy(TSqlParser.Create_security_policyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_security_policy = " + context.GetText());
            }
        }

        public void EnterAlter_sequence(TSqlParser.Alter_sequenceContext context)
        {
            Debug.WriteLine("EnterAlter_sequence = " + context.GetText());
        }

        public void ExitAlter_sequence(TSqlParser.Alter_sequenceContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_sequence = " + context.GetText());
            }
        }

        public void EnterCreate_sequence(TSqlParser.Create_sequenceContext context)
        {
            Debug.WriteLine("EnterCreate_sequence = " + context.GetText());
        }

        public void ExitCreate_sequence(TSqlParser.Create_sequenceContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_sequence = " + context.GetText());
            }
        }

        public void EnterAlter_server_audit(TSqlParser.Alter_server_auditContext context)
        {
            Debug.WriteLine("EnterAlter_server_audit = " + context.GetText());
        }

        public void ExitAlter_server_audit(TSqlParser.Alter_server_auditContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_server_audit = " + context.GetText());
            }
        }

        public void EnterCreate_server_audit(TSqlParser.Create_server_auditContext context)
        {
            Debug.WriteLine("EnterCreate_server_audit = " + context.GetText());
        }

        public void ExitCreate_server_audit(TSqlParser.Create_server_auditContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_server_audit = " + context.GetText());
            }
        }

        public void EnterAlter_server_audit_specification(TSqlParser.Alter_server_audit_specificationContext context)
        {
            Debug.WriteLine("EnterAlter_server_audit_specification = " + context.GetText());
        }

        public void ExitAlter_server_audit_specification(TSqlParser.Alter_server_audit_specificationContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_server_audit_specification = " + context.GetText());
            }
        }

        public void EnterCreate_server_audit_specification(TSqlParser.Create_server_audit_specificationContext context)
        {
            Debug.WriteLine("EnterCreate_server_audit_specification = " + context.GetText());
        }

        public void ExitCreate_server_audit_specification(TSqlParser.Create_server_audit_specificationContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_server_audit_specification = " + context.GetText());
            }
        }

        public void EnterAlter_server_configuration(TSqlParser.Alter_server_configurationContext context)
        {
            Debug.WriteLine("EnterAlter_server_configuration = " + context.GetText());
        }

        public void ExitAlter_server_configuration(TSqlParser.Alter_server_configurationContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_server_configuration = " + context.GetText());
            }
        }

        public void EnterAlter_server_role(TSqlParser.Alter_server_roleContext context)
        {
            Debug.WriteLine("EnterAlter_server_role = " + context.GetText());
        }

        public void ExitAlter_server_role(TSqlParser.Alter_server_roleContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_server_role = " + context.GetText());
            }
        }

        public void EnterCreate_server_role(TSqlParser.Create_server_roleContext context)
        {
            Debug.WriteLine("EnterCreate_server_role = " + context.GetText());
        }

        public void ExitCreate_server_role(TSqlParser.Create_server_roleContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_server_role = " + context.GetText());
            }
        }

        public void EnterAlter_server_role_pdw(TSqlParser.Alter_server_role_pdwContext context)
        {
            Debug.WriteLine("EnterAlter_server_role_pdw = " + context.GetText());
        }

        public void ExitAlter_server_role_pdw(TSqlParser.Alter_server_role_pdwContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_server_role_pdw = " + context.GetText());
            }
        }

        public void EnterAlter_service(TSqlParser.Alter_serviceContext context)
        {
            Debug.WriteLine("EnterAlter_service = " + context.GetText());
        }

        public void ExitAlter_service(TSqlParser.Alter_serviceContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_service = " + context.GetText());
            }
        }

        public void EnterCreate_service(TSqlParser.Create_serviceContext context)
        {
            Debug.WriteLine("EnterCreate_service = " + context.GetText());
        }

        public void ExitCreate_service(TSqlParser.Create_serviceContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_service = " + context.GetText());
            }
        }

        public void EnterAlter_service_master_key(TSqlParser.Alter_service_master_keyContext context)
        {
            Debug.WriteLine("EnterAlter_service_master_key = " + context.GetText());
        }

        public void ExitAlter_service_master_key(TSqlParser.Alter_service_master_keyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_service_master_key = " + context.GetText());
            }
        }

        public void EnterAlter_symmetric_key(TSqlParser.Alter_symmetric_keyContext context)
        {
            Debug.WriteLine("EnterAlter_symmetric_key = " + context.GetText());
        }

        public void ExitAlter_symmetric_key(TSqlParser.Alter_symmetric_keyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_symmetric_key = " + context.GetText());
            }
        }

        public void EnterCreate_symmetric_key(TSqlParser.Create_symmetric_keyContext context)
        {
            Debug.WriteLine("EnterCreate_symmetric_key = " + context.GetText());
        }

        public void ExitCreate_symmetric_key(TSqlParser.Create_symmetric_keyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_symmetric_key = " + context.GetText());
            }
        }

        public void EnterCreate_synonym(TSqlParser.Create_synonymContext context)
        {
            Debug.WriteLine("EnterCreate_synonym = " + context.GetText());
        }

        public void ExitCreate_synonym(TSqlParser.Create_synonymContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_synonym = " + context.GetText());
            }
        }

        public void EnterAlter_user(TSqlParser.Alter_userContext context)
        {
            Debug.WriteLine("EnterAlter_user = " + context.GetText());
        }

        public void ExitAlter_user(TSqlParser.Alter_userContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_user = " + context.GetText());
            }
        }

        public void EnterCreate_user(TSqlParser.Create_userContext context)
        {
            Debug.WriteLine("EnterCreate_user = " + context.GetText());
        }

        public void ExitCreate_user(TSqlParser.Create_userContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_user = " + context.GetText());
            }
        }

        public void EnterCreate_user_azure_sql_dw(TSqlParser.Create_user_azure_sql_dwContext context)
        {
            Debug.WriteLine("EnterCreate_user_azure_sql_dw = " + context.GetText());
        }

        public void ExitCreate_user_azure_sql_dw(TSqlParser.Create_user_azure_sql_dwContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_user_azure_sql_dw = " + context.GetText());
            }
        }

        public void EnterAlter_user_azure_sql(TSqlParser.Alter_user_azure_sqlContext context)
        {
            Debug.WriteLine("EnterAlter_user_azure_sql = " + context.GetText());
        }

        public void ExitAlter_user_azure_sql(TSqlParser.Alter_user_azure_sqlContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_user_azure_sql = " + context.GetText());
            }
        }

        public void EnterAlter_workload_group(TSqlParser.Alter_workload_groupContext context)
        {
            Debug.WriteLine("EnterAlter_workload_group = " + context.GetText());
        }

        public void ExitAlter_workload_group(TSqlParser.Alter_workload_groupContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_workload_group = " + context.GetText());
            }
        }

        public void EnterCreate_workload_group(TSqlParser.Create_workload_groupContext context)
        {
            Debug.WriteLine("EnterCreate_workload_group = " + context.GetText());
        }

        public void ExitCreate_workload_group(TSqlParser.Create_workload_groupContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_workload_group = " + context.GetText());
            }
        }

        public void EnterCreate_xml_schema_collection(TSqlParser.Create_xml_schema_collectionContext context)
        {
            Debug.WriteLine("EnterCreate_xml_schema_collection = " + context.GetText());
        }

        public void ExitCreate_xml_schema_collection(TSqlParser.Create_xml_schema_collectionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_xml_schema_collection = " + context.GetText());
            }
        }

        public void EnterCreate_queue(TSqlParser.Create_queueContext context)
        {
            Debug.WriteLine("EnterCreate_queue = " + context.GetText());
        }

        public void ExitCreate_queue(TSqlParser.Create_queueContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_queue = " + context.GetText());
            }
        }

        public void EnterQueue_settings(TSqlParser.Queue_settingsContext context)
        {
            Debug.WriteLine("EnterQueue_settings = " + context.GetText());
        }

        public void ExitQueue_settings(TSqlParser.Queue_settingsContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitQueue_settings = " + context.GetText());
            }
        }

        public void EnterAlter_queue(TSqlParser.Alter_queueContext context)
        {
            Debug.WriteLine("EnterAlter_queue = " + context.GetText());
        }

        public void ExitAlter_queue(TSqlParser.Alter_queueContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_queue = " + context.GetText());
            }
        }

        public void EnterQueue_action(TSqlParser.Queue_actionContext context)
        {
            Debug.WriteLine("EnterQueue_action = " + context.GetText());
        }

        public void ExitQueue_action(TSqlParser.Queue_actionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitQueue_action = " + context.GetText());
            }
        }

        public void EnterQueue_rebuild_options(TSqlParser.Queue_rebuild_optionsContext context)
        {
            Debug.WriteLine("EnterQueue_rebuild_options = " + context.GetText());
        }

        public void ExitQueue_rebuild_options(TSqlParser.Queue_rebuild_optionsContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitQueue_rebuild_options = " + context.GetText());
            }
        }

        public void EnterCreate_contract(TSqlParser.Create_contractContext context)
        {
            Debug.WriteLine("EnterCreate_contract = " + context.GetText());
        }

        public void ExitCreate_contract(TSqlParser.Create_contractContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_contract = " + context.GetText());
            }
        }

        public void EnterConversation_statement(TSqlParser.Conversation_statementContext context)
        {
            Debug.WriteLine("EnterConversation_statement = " + context.GetText());
        }

        public void ExitConversation_statement(TSqlParser.Conversation_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitConversation_statement = " + context.GetText());
            }
        }

        public void EnterMessage_statement(TSqlParser.Message_statementContext context)
        {
            Debug.WriteLine("EnterMessage_statement = " + context.GetText());
        }

        public void ExitMessage_statement(TSqlParser.Message_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitMessage_statement = " + context.GetText());
            }
        }

        public void EnterMerge_statement(TSqlParser.Merge_statementContext context)
        {
            Debug.WriteLine("EnterMerge_statement = " + context.GetText());
        }

        public void ExitMerge_statement(TSqlParser.Merge_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitMerge_statement = " + context.GetText());
            }
        }

        public void EnterMerge_matched(TSqlParser.Merge_matchedContext context)
        {
            Debug.WriteLine("EnterMerge_matched = " + context.GetText());
        }

        public void ExitMerge_matched(TSqlParser.Merge_matchedContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitMerge_matched = " + context.GetText());
            }
        }

        public void EnterMerge_not_matched(TSqlParser.Merge_not_matchedContext context)
        {
            Debug.WriteLine("EnterMerge_not_matched = " + context.GetText());
        }

        public void ExitMerge_not_matched(TSqlParser.Merge_not_matchedContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitMerge_not_matched = " + context.GetText());
            }
        }

        public void EnterDelete_statement(TSqlParser.Delete_statementContext context)
        {
            Debug.WriteLine("EnterDelete_statement = " + context.GetText());
        }

        public void ExitDelete_statement(TSqlParser.Delete_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDelete_statement = " + context.GetText());
            }
        }

        public void EnterDelete_statement_from(TSqlParser.Delete_statement_fromContext context)
        {
            Debug.WriteLine("EnterDelete_statement_from = " + context.GetText());
        }

        public void ExitDelete_statement_from(TSqlParser.Delete_statement_fromContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDelete_statement_from = " + context.GetText());
            }
        }

        public void EnterInsert_statement(TSqlParser.Insert_statementContext context)
        {
            Debug.WriteLine("EnterInsert_statement = " + context.GetText());
        }

        public void ExitInsert_statement(TSqlParser.Insert_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitInsert_statement = " + context.GetText());
            }
        }

        public void EnterInsert_statement_value(TSqlParser.Insert_statement_valueContext context)
        {
            Debug.WriteLine("EnterInsert_statement_value = " + context.GetText());
        }

        public void ExitInsert_statement_value(TSqlParser.Insert_statement_valueContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitInsert_statement_value = " + context.GetText());
            }
        }

        public void EnterReceive_statement(TSqlParser.Receive_statementContext context)
        {
            Debug.WriteLine("EnterReceive_statement = " + context.GetText());
        }

        public void ExitReceive_statement(TSqlParser.Receive_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitReceive_statement = " + context.GetText());
            }
        }

        public void EnterSelect_statement(TSqlParser.Select_statementContext context)
        {
            Debug.WriteLine("EnterSelect_statement = " + context.GetText());
        }

        public void ExitSelect_statement(TSqlParser.Select_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSelect_statement = " + context.GetText());
            }
        }

        public void EnterTime(TSqlParser.TimeContext context)
        {
            Debug.WriteLine("EnterTime = " + context.GetText());
        }

        public void ExitTime(TSqlParser.TimeContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitTime = " + context.GetText());
            }
        }

        public void EnterUpdate_statement(TSqlParser.Update_statementContext context)
        {
            Debug.WriteLine("EnterUpdate_statement = " + context.GetText());
        }

        public void ExitUpdate_statement(TSqlParser.Update_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitUpdate_statement = " + context.GetText());
            }
        }

        public void EnterOutput_clause(TSqlParser.Output_clauseContext context)
        {
            Debug.WriteLine("EnterOutput_clause = " + context.GetText());
        }

        public void ExitOutput_clause(TSqlParser.Output_clauseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitOutput_clause = " + context.GetText());
            }
        }

        public void EnterOutput_dml_list_elem(TSqlParser.Output_dml_list_elemContext context)
        {
            Debug.WriteLine("EnterOutput_dml_list_elem = " + context.GetText());
        }

        public void ExitOutput_dml_list_elem(TSqlParser.Output_dml_list_elemContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitOutput_dml_list_elem = " + context.GetText());
            }
        }

        public void EnterOutput_column_name(TSqlParser.Output_column_nameContext context)
        {
            Debug.WriteLine("EnterOutput_column_name = " + context.GetText());
        }

        public void ExitOutput_column_name(TSqlParser.Output_column_nameContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitOutput_column_name = " + context.GetText());
            }
        }

        public void EnterCreate_database(TSqlParser.Create_databaseContext context)
        {
            Debug.WriteLine("EnterCreate_database = " + context.GetText());
        }

        public void ExitCreate_database(TSqlParser.Create_databaseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_database = " + context.GetText());
            }
        }

        public void EnterCreate_index(TSqlParser.Create_indexContext context)
        {
            Debug.WriteLine("EnterCreate_index = " + context.GetText());
        }

        public void ExitCreate_index(TSqlParser.Create_indexContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_index = " + context.GetText());
            }
        }

        public void EnterCreate_or_alter_procedure(TSqlParser.Create_or_alter_procedureContext context)
        {
            Debug.WriteLine("EnterCreate_or_alter_procedure = " + context.GetText());
        }

        public void ExitCreate_or_alter_procedure(TSqlParser.Create_or_alter_procedureContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_or_alter_procedure = " + context.GetText());
            }
        }

        public void EnterCreate_or_alter_trigger(TSqlParser.Create_or_alter_triggerContext context)
        {
            Debug.WriteLine("EnterCreate_or_alter_trigger = " + context.GetText());
        }

        public void ExitCreate_or_alter_trigger(TSqlParser.Create_or_alter_triggerContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_or_alter_trigger = " + context.GetText());
            }
        }

        public void EnterCreate_or_alter_dml_trigger(TSqlParser.Create_or_alter_dml_triggerContext context)
        {
            Debug.WriteLine("EnterCreate_or_alter_dml_trigger = " + context.GetText());
        }

        public void ExitCreate_or_alter_dml_trigger(TSqlParser.Create_or_alter_dml_triggerContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_or_alter_dml_trigger = " + context.GetText());
            }
        }

        public void EnterDml_trigger_option(TSqlParser.Dml_trigger_optionContext context)
        {
            Debug.WriteLine("EnterDml_trigger_option = " + context.GetText());
        }

        public void ExitDml_trigger_option(TSqlParser.Dml_trigger_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDml_trigger_option = " + context.GetText());
            }
        }

        public void EnterDml_trigger_operation(TSqlParser.Dml_trigger_operationContext context)
        {
            Debug.WriteLine("EnterDml_trigger_operation = " + context.GetText());
        }

        public void ExitDml_trigger_operation(TSqlParser.Dml_trigger_operationContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDml_trigger_operation = " + context.GetText());
            }
        }

        public void EnterCreate_or_alter_ddl_trigger(TSqlParser.Create_or_alter_ddl_triggerContext context)
        {
            Debug.WriteLine("EnterCreate_or_alter_ddl_trigger = " + context.GetText());
        }

        public void ExitCreate_or_alter_ddl_trigger(TSqlParser.Create_or_alter_ddl_triggerContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_or_alter_ddl_trigger = " + context.GetText());
            }
        }

        public void EnterDdl_trigger_operation(TSqlParser.Ddl_trigger_operationContext context)
        {
            Debug.WriteLine("EnterDdl_trigger_operation = " + context.GetText());
        }

        public void ExitDdl_trigger_operation(TSqlParser.Ddl_trigger_operationContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDdl_trigger_operation = " + context.GetText());
            }
        }

        public void EnterCreate_or_alter_function(TSqlParser.Create_or_alter_functionContext context)
        {
            Debug.WriteLine("EnterCreate_or_alter_function = " + context.GetText());
        }

        public void ExitCreate_or_alter_function(TSqlParser.Create_or_alter_functionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_or_alter_function = " + context.GetText());
            }
        }

        public void EnterFunc_body_returns_select(TSqlParser.Func_body_returns_selectContext context)
        {
            Debug.WriteLine("EnterFunc_body_returns_select = " + context.GetText());
        }

        public void ExitFunc_body_returns_select(TSqlParser.Func_body_returns_selectContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitFunc_body_returns_select = " + context.GetText());
            }
        }

        public void EnterFunc_body_returns_table(TSqlParser.Func_body_returns_tableContext context)
        {
            Debug.WriteLine("EnterFunc_body_returns_table = " + context.GetText());
        }

        public void ExitFunc_body_returns_table(TSqlParser.Func_body_returns_tableContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitFunc_body_returns_table = " + context.GetText());
            }
        }

        public void EnterFunc_body_returns_scalar(TSqlParser.Func_body_returns_scalarContext context)
        {
            Debug.WriteLine("EnterFunc_body_returns_scalar = " + context.GetText());
        }

        public void ExitFunc_body_returns_scalar(TSqlParser.Func_body_returns_scalarContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitFunc_body_returns_scalar = " + context.GetText());
            }
        }

        public void EnterProcedure_param(TSqlParser.Procedure_paramContext context)
        {
            Debug.WriteLine("EnterProcedure_param = " + context.GetText());
        }

        public void ExitProcedure_param(TSqlParser.Procedure_paramContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitProcedure_param = " + context.GetText());
            }
        }

        public void EnterProcedure_option(TSqlParser.Procedure_optionContext context)
        {
            Debug.WriteLine("EnterProcedure_option = " + context.GetText());
        }

        public void ExitProcedure_option(TSqlParser.Procedure_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitProcedure_option = " + context.GetText());
            }
        }

        public void EnterFunction_option(TSqlParser.Function_optionContext context)
        {
            Debug.WriteLine("EnterFunction_option = " + context.GetText());
        }

        public void ExitFunction_option(TSqlParser.Function_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitFunction_option = " + context.GetText());
            }
        }

        public void EnterCreate_statistics(TSqlParser.Create_statisticsContext context)
        {
            Debug.WriteLine("EnterCreate_statistics = " + context.GetText());
        }

        public void ExitCreate_statistics(TSqlParser.Create_statisticsContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_statistics = " + context.GetText());
            }
        }

        public void EnterCreate_table(TSqlParser.Create_tableContext context)
        {
            Debug.WriteLine("EnterCreate_table = " + context.GetText());
        }

        public void ExitCreate_table(TSqlParser.Create_tableContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_table = " + context.GetText());
            }
        }

        public void EnterTable_options(TSqlParser.Table_optionsContext context)
        {
            Debug.WriteLine("EnterTable_options = " + context.GetText());
        }

        public void ExitTable_options(TSqlParser.Table_optionsContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitTable_options = " + context.GetText());
            }
        }

        public void EnterCreate_view(TSqlParser.Create_viewContext context)
        {
            Debug.WriteLine("EnterCreate_view = " + context.GetText());
        }

        public void ExitCreate_view(TSqlParser.Create_viewContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_view = " + context.GetText());
            }
        }

        public void EnterView_attribute(TSqlParser.View_attributeContext context)
        {
            Debug.WriteLine("EnterView_attribute = " + context.GetText());
        }

        public void ExitView_attribute(TSqlParser.View_attributeContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitView_attribute = " + context.GetText());
            }
        }

        public void EnterAlter_table(TSqlParser.Alter_tableContext context)
        {
            Debug.WriteLine("EnterAlter_table = " + context.GetText());
        }

        public void ExitAlter_table(TSqlParser.Alter_tableContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_table = " + context.GetText());
            }
        }

        public void EnterAlter_database(TSqlParser.Alter_databaseContext context)
        {
            Debug.WriteLine("EnterAlter_database = " + context.GetText());
        }

        public void ExitAlter_database(TSqlParser.Alter_databaseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_database = " + context.GetText());
            }
        }

        public void EnterDatabase_optionspec(TSqlParser.Database_optionspecContext context)
        {
            Debug.WriteLine("EnterDatabase_optionspec = " + context.GetText());
        }

        public void ExitDatabase_optionspec(TSqlParser.Database_optionspecContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDatabase_optionspec = " + context.GetText());
            }
        }

        public void EnterAuto_option(TSqlParser.Auto_optionContext context)
        {
            Debug.WriteLine("EnterAuto_option = " + context.GetText());
        }

        public void ExitAuto_option(TSqlParser.Auto_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAuto_option = " + context.GetText());
            }
        }

        public void EnterChange_tracking_option(TSqlParser.Change_tracking_optionContext context)
        {
            Debug.WriteLine("EnterChange_tracking_option = " + context.GetText());
        }

        public void ExitChange_tracking_option(TSqlParser.Change_tracking_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitChange_tracking_option = " + context.GetText());
            }
        }

        public void EnterChange_tracking_option_list(TSqlParser.Change_tracking_option_listContext context)
        {
            Debug.WriteLine("EnterChange_tracking_option_list = " + context.GetText());
        }

        public void ExitChange_tracking_option_list(TSqlParser.Change_tracking_option_listContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitChange_tracking_option_list = " + context.GetText());
            }
        }

        public void EnterContainment_option(TSqlParser.Containment_optionContext context)
        {
            Debug.WriteLine("EnterContainment_option = " + context.GetText());
        }

        public void ExitContainment_option(TSqlParser.Containment_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitContainment_option = " + context.GetText());
            }
        }

        public void EnterCursor_option(TSqlParser.Cursor_optionContext context)
        {
            Debug.WriteLine("EnterCursor_option = " + context.GetText());
        }

        public void ExitCursor_option(TSqlParser.Cursor_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCursor_option = " + context.GetText());
            }
        }

        public void EnterAlter_endpoint(TSqlParser.Alter_endpointContext context)
        {
            Debug.WriteLine("EnterAlter_endpoint = " + context.GetText());
        }

        public void ExitAlter_endpoint(TSqlParser.Alter_endpointContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlter_endpoint = " + context.GetText());
            }
        }

        public void EnterDatabase_mirroring_option(TSqlParser.Database_mirroring_optionContext context)
        {
            Debug.WriteLine("EnterDatabase_mirroring_option = " + context.GetText());
        }

        public void ExitDatabase_mirroring_option(TSqlParser.Database_mirroring_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDatabase_mirroring_option = " + context.GetText());
            }
        }

        public void EnterMirroring_set_option(TSqlParser.Mirroring_set_optionContext context)
        {
            Debug.WriteLine("EnterMirroring_set_option = " + context.GetText());
        }

        public void ExitMirroring_set_option(TSqlParser.Mirroring_set_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitMirroring_set_option = " + context.GetText());
            }
        }

        public void EnterMirroring_partner(TSqlParser.Mirroring_partnerContext context)
        {
            Debug.WriteLine("EnterMirroring_partner = " + context.GetText());
        }

        public void ExitMirroring_partner(TSqlParser.Mirroring_partnerContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitMirroring_partner = " + context.GetText());
            }
        }

        public void EnterMirroring_witness(TSqlParser.Mirroring_witnessContext context)
        {
            Debug.WriteLine("EnterMirroring_witness = " + context.GetText());
        }

        public void ExitMirroring_witness(TSqlParser.Mirroring_witnessContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitMirroring_witness = " + context.GetText());
            }
        }

        public void EnterWitness_partner_equal(TSqlParser.Witness_partner_equalContext context)
        {
            Debug.WriteLine("EnterWitness_partner_equal = " + context.GetText());
        }

        public void ExitWitness_partner_equal(TSqlParser.Witness_partner_equalContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitWitness_partner_equal = " + context.GetText());
            }
        }

        public void EnterPartner_option(TSqlParser.Partner_optionContext context)
        {
            Debug.WriteLine("EnterPartner_option = " + context.GetText());
        }

        public void ExitPartner_option(TSqlParser.Partner_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitPartner_option = " + context.GetText());
            }
        }

        public void EnterWitness_option(TSqlParser.Witness_optionContext context)
        {
            Debug.WriteLine("EnterWitness_option = " + context.GetText());
        }

        public void ExitWitness_option(TSqlParser.Witness_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitWitness_option = " + context.GetText());
            }
        }

        public void EnterWitness_server(TSqlParser.Witness_serverContext context)
        {
            Debug.WriteLine("EnterWitness_server = " + context.GetText());
        }

        public void ExitWitness_server(TSqlParser.Witness_serverContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitWitness_server = " + context.GetText());
            }
        }

        public void EnterPartner_server(TSqlParser.Partner_serverContext context)
        {
            Debug.WriteLine("EnterPartner_server = " + context.GetText());
        }

        public void ExitPartner_server(TSqlParser.Partner_serverContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitPartner_server = " + context.GetText());
            }
        }

        public void EnterMirroring_host_port_seperator(TSqlParser.Mirroring_host_port_seperatorContext context)
        {
            Debug.WriteLine("EnterMirroring_host_port_seperator = " + context.GetText());
        }

        public void ExitMirroring_host_port_seperator(TSqlParser.Mirroring_host_port_seperatorContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitMirroring_host_port_seperator = " + context.GetText());
            }
        }

        public void EnterPartner_server_tcp_prefix(TSqlParser.Partner_server_tcp_prefixContext context)
        {
            Debug.WriteLine("EnterPartner_server_tcp_prefix = " + context.GetText());
        }

        public void ExitPartner_server_tcp_prefix(TSqlParser.Partner_server_tcp_prefixContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitPartner_server_tcp_prefix = " + context.GetText());
            }
        }

        public void EnterPort_number(TSqlParser.Port_numberContext context)
        {
            Debug.WriteLine("EnterPort_number = " + context.GetText());
        }

        public void ExitPort_number(TSqlParser.Port_numberContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitPort_number = " + context.GetText());
            }
        }

        public void EnterHost(TSqlParser.HostContext context)
        {
            Debug.WriteLine("EnterHost = " + context.GetText());
        }

        public void ExitHost(TSqlParser.HostContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitHost = " + context.GetText());
            }
        }

        public void EnterDate_correlation_optimization_option(
            TSqlParser.Date_correlation_optimization_optionContext context)
        {
            Debug.WriteLine("EnterDate_correlation_optimization_option = " + context.GetText());
        }

        public void ExitDate_correlation_optimization_option(
            TSqlParser.Date_correlation_optimization_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDate_correlation_optimization_option = " + context.GetText());
            }
        }

        public void EnterDb_encryption_option(TSqlParser.Db_encryption_optionContext context)
        {
            Debug.WriteLine("EnterDb_encryption_option = " + context.GetText());
        }

        public void ExitDb_encryption_option(TSqlParser.Db_encryption_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDb_encryption_option = " + context.GetText());
            }
        }

        public void EnterDb_state_option(TSqlParser.Db_state_optionContext context)
        {
            Debug.WriteLine("EnterDb_state_option = " + context.GetText());
        }

        public void ExitDb_state_option(TSqlParser.Db_state_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDb_state_option = " + context.GetText());
            }
        }

        public void EnterDb_update_option(TSqlParser.Db_update_optionContext context)
        {
            Debug.WriteLine("EnterDb_update_option = " + context.GetText());
        }

        public void ExitDb_update_option(TSqlParser.Db_update_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDb_update_option = " + context.GetText());
            }
        }

        public void EnterDb_user_access_option(TSqlParser.Db_user_access_optionContext context)
        {
            Debug.WriteLine("EnterDb_user_access_option = " + context.GetText());
        }

        public void ExitDb_user_access_option(TSqlParser.Db_user_access_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDb_user_access_option = " + context.GetText());
            }
        }

        public void EnterDelayed_durability_option(TSqlParser.Delayed_durability_optionContext context)
        {
            Debug.WriteLine("EnterDelayed_durability_option = " + context.GetText());
        }

        public void ExitDelayed_durability_option(TSqlParser.Delayed_durability_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDelayed_durability_option = " + context.GetText());
            }
        }

        public void EnterExternal_access_option(TSqlParser.External_access_optionContext context)
        {
            Debug.WriteLine("EnterExternal_access_option = " + context.GetText());
        }

        public void ExitExternal_access_option(TSqlParser.External_access_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitExternal_access_option = " + context.GetText());
            }
        }

        public void EnterHadr_options(TSqlParser.Hadr_optionsContext context)
        {
            Debug.WriteLine("EnterHadr_options = " + context.GetText());
        }

        public void ExitHadr_options(TSqlParser.Hadr_optionsContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitHadr_options = " + context.GetText());
            }
        }

        public void EnterMixed_page_allocation_option(TSqlParser.Mixed_page_allocation_optionContext context)
        {
            Debug.WriteLine("EnterMixed_page_allocation_option = " + context.GetText());
        }

        public void ExitMixed_page_allocation_option(TSqlParser.Mixed_page_allocation_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitMixed_page_allocation_option = " + context.GetText());
            }
        }

        public void EnterParameterization_option(TSqlParser.Parameterization_optionContext context)
        {
            Debug.WriteLine("EnterParameterization_option = " + context.GetText());
        }

        public void ExitParameterization_option(TSqlParser.Parameterization_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitParameterization_option = " + context.GetText());
            }
        }

        public void EnterRecovery_option(TSqlParser.Recovery_optionContext context)
        {
            Debug.WriteLine("EnterRecovery_option = " + context.GetText());
        }

        public void ExitRecovery_option(TSqlParser.Recovery_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitRecovery_option = " + context.GetText());
            }
        }

        public void EnterService_broker_option(TSqlParser.Service_broker_optionContext context)
        {
            Debug.WriteLine("EnterService_broker_option = " + context.GetText());
        }

        public void ExitService_broker_option(TSqlParser.Service_broker_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitService_broker_option = " + context.GetText());
            }
        }

        public void EnterSnapshot_option(TSqlParser.Snapshot_optionContext context)
        {
            Debug.WriteLine("EnterSnapshot_option = " + context.GetText());
        }

        public void ExitSnapshot_option(TSqlParser.Snapshot_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSnapshot_option = " + context.GetText());
            }
        }

        public void EnterSql_option(TSqlParser.Sql_optionContext context)
        {
            Debug.WriteLine("EnterSql_option = " + context.GetText());
        }

        public void ExitSql_option(TSqlParser.Sql_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSql_option = " + context.GetText());
            }
        }

        public void EnterTarget_recovery_time_option(TSqlParser.Target_recovery_time_optionContext context)
        {
            Debug.WriteLine("EnterTarget_recovery_time_option = " + context.GetText());
        }

        public void ExitTarget_recovery_time_option(TSqlParser.Target_recovery_time_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitTarget_recovery_time_option = " + context.GetText());
            }
        }

        public void EnterTermination(TSqlParser.TerminationContext context)
        {
            Debug.WriteLine("EnterTermination = " + context.GetText());
        }

        public void ExitTermination(TSqlParser.TerminationContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitTermination = " + context.GetText());
            }
        }

        public void EnterDrop_index(TSqlParser.Drop_indexContext context)
        {
            Debug.WriteLine("EnterDrop_index = " + context.GetText());
        }

        public void ExitDrop_index(TSqlParser.Drop_indexContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_index = " + context.GetText());
            }
        }

        public void EnterDrop_relational_or_xml_or_spatial_index(
            TSqlParser.Drop_relational_or_xml_or_spatial_indexContext context)
        {
            Debug.WriteLine("EnterDrop_relational_or_xml_or_spatial_index = " + context.GetText());
        }

        public void ExitDrop_relational_or_xml_or_spatial_index(
            TSqlParser.Drop_relational_or_xml_or_spatial_indexContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_relational_or_xml_or_spatial_index = " + context.GetText());
            }
        }

        public void EnterDrop_backward_compatible_index(TSqlParser.Drop_backward_compatible_indexContext context)
        {
            Debug.WriteLine("EnterDrop_backward_compatible_index = " + context.GetText());
        }

        public void ExitDrop_backward_compatible_index(TSqlParser.Drop_backward_compatible_indexContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_backward_compatible_index = " + context.GetText());
            }
        }

        public void EnterDrop_procedure(TSqlParser.Drop_procedureContext context)
        {
            Debug.WriteLine("EnterDrop_procedure = " + context.GetText());
        }

        public void ExitDrop_procedure(TSqlParser.Drop_procedureContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_procedure = " + context.GetText());
            }
        }

        public void EnterDrop_trigger(TSqlParser.Drop_triggerContext context)
        {
            Debug.WriteLine("EnterDrop_trigger = " + context.GetText());
        }

        public void ExitDrop_trigger(TSqlParser.Drop_triggerContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_trigger = " + context.GetText());
            }
        }

        public void EnterDrop_dml_trigger(TSqlParser.Drop_dml_triggerContext context)
        {
            Debug.WriteLine("EnterDrop_dml_trigger = " + context.GetText());
        }

        public void ExitDrop_dml_trigger(TSqlParser.Drop_dml_triggerContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_dml_trigger = " + context.GetText());
            }
        }

        public void EnterDrop_ddl_trigger(TSqlParser.Drop_ddl_triggerContext context)
        {
            Debug.WriteLine("EnterDrop_ddl_trigger = " + context.GetText());
        }

        public void ExitDrop_ddl_trigger(TSqlParser.Drop_ddl_triggerContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_ddl_trigger = " + context.GetText());
            }
        }

        public void EnterDrop_function(TSqlParser.Drop_functionContext context)
        {
            Debug.WriteLine("EnterDrop_function = " + context.GetText());
        }

        public void ExitDrop_function(TSqlParser.Drop_functionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_function = " + context.GetText());
            }
        }

        public void EnterDrop_statistics(TSqlParser.Drop_statisticsContext context)
        {
            Debug.WriteLine("EnterDrop_statistics = " + context.GetText());
        }

        public void ExitDrop_statistics(TSqlParser.Drop_statisticsContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_statistics = " + context.GetText());
            }
        }

        public void EnterDrop_table(TSqlParser.Drop_tableContext context)
        {
            Debug.WriteLine("EnterDrop_table = " + context.GetText());
        }

        public void ExitDrop_table(TSqlParser.Drop_tableContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_table = " + context.GetText());
            }
        }

        public void EnterDrop_view(TSqlParser.Drop_viewContext context)
        {
            Debug.WriteLine("EnterDrop_view = " + context.GetText());
        }

        public void ExitDrop_view(TSqlParser.Drop_viewContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_view = " + context.GetText());
            }
        }

        public void EnterCreate_type(TSqlParser.Create_typeContext context)
        {
            Debug.WriteLine("EnterCreate_type = " + context.GetText());
        }

        public void ExitCreate_type(TSqlParser.Create_typeContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_type = " + context.GetText());
            }
        }

        public void EnterDrop_type(TSqlParser.Drop_typeContext context)
        {
            Debug.WriteLine("EnterDrop_type = " + context.GetText());
        }

        public void ExitDrop_type(TSqlParser.Drop_typeContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDrop_type = " + context.GetText());
            }
        }

        public void EnterRowset_function_limited(TSqlParser.Rowset_function_limitedContext context)
        {
            Debug.WriteLine("EnterRowset_function_limited = " + context.GetText());
        }

        public void ExitRowset_function_limited(TSqlParser.Rowset_function_limitedContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitRowset_function_limited = " + context.GetText());
            }
        }

        public void EnterOpenquery(TSqlParser.OpenqueryContext context)
        {
            Debug.WriteLine("EnterOpenquery = " + context.GetText());
        }

        public void ExitOpenquery(TSqlParser.OpenqueryContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitOpenquery = " + context.GetText());
            }
        }

        public void EnterOpendatasource(TSqlParser.OpendatasourceContext context)
        {
            Debug.WriteLine("EnterOpendatasource = " + context.GetText());
        }

        public void ExitOpendatasource(TSqlParser.OpendatasourceContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitOpendatasource = " + context.GetText());
            }
        }

        public void EnterDeclare_statement(TSqlParser.Declare_statementContext context)
        {
            Debug.WriteLine("EnterDeclare_statement = " + context.GetText());
        }

        public void ExitDeclare_statement(TSqlParser.Declare_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDeclare_statement = " + context.GetText());
            }
        }

        public void EnterCursor_statement(TSqlParser.Cursor_statementContext context)
        {
            Debug.WriteLine("EnterCursor_statement = " + context.GetText());
        }

        public void ExitCursor_statement(TSqlParser.Cursor_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCursor_statement = " + context.GetText());
            }
        }

        public void EnterBackup_database(TSqlParser.Backup_databaseContext context)
        {
            Debug.WriteLine("EnterBackup_database = " + context.GetText());
        }

        public void ExitBackup_database(TSqlParser.Backup_databaseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitBackup_database = " + context.GetText());
            }
        }

        public void EnterBackup_log(TSqlParser.Backup_logContext context)
        {
            Debug.WriteLine("EnterBackup_log = " + context.GetText());
        }

        public void ExitBackup_log(TSqlParser.Backup_logContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitBackup_log = " + context.GetText());
            }
        }

        public void EnterBackup_certificate(TSqlParser.Backup_certificateContext context)
        {
            Debug.WriteLine("EnterBackup_certificate = " + context.GetText());
        }

        public void ExitBackup_certificate(TSqlParser.Backup_certificateContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitBackup_certificate = " + context.GetText());
            }
        }

        public void EnterBackup_master_key(TSqlParser.Backup_master_keyContext context)
        {
            Debug.WriteLine("EnterBackup_master_key = " + context.GetText());
        }

        public void ExitBackup_master_key(TSqlParser.Backup_master_keyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitBackup_master_key = " + context.GetText());
            }
        }

        public void EnterBackup_service_master_key(TSqlParser.Backup_service_master_keyContext context)
        {
            Debug.WriteLine("EnterBackup_service_master_key = " + context.GetText());
        }

        public void ExitBackup_service_master_key(TSqlParser.Backup_service_master_keyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitBackup_service_master_key = " + context.GetText());
            }
        }

        public void EnterExecute_statement(TSqlParser.Execute_statementContext context)
        {
            Debug.WriteLine("EnterExecute_statement = " + context.GetText());
        }

        public void ExitExecute_statement(TSqlParser.Execute_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitExecute_statement = " + context.GetText());
            }
        }

        public void EnterExecute_statement_arg(TSqlParser.Execute_statement_argContext context)
        {
            Debug.WriteLine("EnterExecute_statement_arg = " + context.GetText());
        }

        public void ExitExecute_statement_arg(TSqlParser.Execute_statement_argContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitExecute_statement_arg = " + context.GetText());
            }
        }

        public void EnterExecute_var_string(TSqlParser.Execute_var_stringContext context)
        {
            Debug.WriteLine("EnterExecute_var_string = " + context.GetText());
        }

        public void ExitExecute_var_string(TSqlParser.Execute_var_stringContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitExecute_var_string = " + context.GetText());
            }
        }

        public void EnterSecurity_statement(TSqlParser.Security_statementContext context)
        {
            Debug.WriteLine("EnterSecurity_statement = " + context.GetText());
        }

        public void ExitSecurity_statement(TSqlParser.Security_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSecurity_statement = " + context.GetText());
            }
        }

        public void EnterCreate_certificate(TSqlParser.Create_certificateContext context)
        {
            Debug.WriteLine("EnterCreate_certificate = " + context.GetText());
        }

        public void ExitCreate_certificate(TSqlParser.Create_certificateContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_certificate = " + context.GetText());
            }
        }

        public void EnterExisting_keys(TSqlParser.Existing_keysContext context)
        {
            Debug.WriteLine("EnterExisting_keys = " + context.GetText());
        }

        public void ExitExisting_keys(TSqlParser.Existing_keysContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitExisting_keys = " + context.GetText());
            }
        }

        public void EnterPrivate_key_options(TSqlParser.Private_key_optionsContext context)
        {
            Debug.WriteLine("EnterPrivate_key_options = " + context.GetText());
        }

        public void ExitPrivate_key_options(TSqlParser.Private_key_optionsContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitPrivate_key_options = " + context.GetText());
            }
        }

        public void EnterGenerate_new_keys(TSqlParser.Generate_new_keysContext context)
        {
            Debug.WriteLine("EnterGenerate_new_keys = " + context.GetText());
        }

        public void ExitGenerate_new_keys(TSqlParser.Generate_new_keysContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitGenerate_new_keys = " + context.GetText());
            }
        }

        public void EnterDate_options(TSqlParser.Date_optionsContext context)
        {
            Debug.WriteLine("EnterDate_options = " + context.GetText());
        }

        public void ExitDate_options(TSqlParser.Date_optionsContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDate_options = " + context.GetText());
            }
        }

        public void EnterOpen_key(TSqlParser.Open_keyContext context)
        {
            Debug.WriteLine("EnterOpen_key = " + context.GetText());
        }

        public void ExitOpen_key(TSqlParser.Open_keyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitOpen_key = " + context.GetText());
            }
        }

        public void EnterClose_key(TSqlParser.Close_keyContext context)
        {
            Debug.WriteLine("EnterClose_key = " + context.GetText());
        }

        public void ExitClose_key(TSqlParser.Close_keyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitClose_key = " + context.GetText());
            }
        }

        public void EnterCreate_key(TSqlParser.Create_keyContext context)
        {
            Debug.WriteLine("EnterCreate_key = " + context.GetText());
        }

        public void ExitCreate_key(TSqlParser.Create_keyContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_key = " + context.GetText());
            }
        }

        public void EnterKey_options(TSqlParser.Key_optionsContext context)
        {
            Debug.WriteLine("EnterKey_options = " + context.GetText());
        }

        public void ExitKey_options(TSqlParser.Key_optionsContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitKey_options = " + context.GetText());
            }
        }

        public void EnterAlgorithm(TSqlParser.AlgorithmContext context)
        {
            Debug.WriteLine("EnterAlgorithm = " + context.GetText());
        }

        public void ExitAlgorithm(TSqlParser.AlgorithmContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAlgorithm = " + context.GetText());
            }
        }

        public void EnterEncryption_mechanism(TSqlParser.Encryption_mechanismContext context)
        {
            Debug.WriteLine("EnterEncryption_mechanism = " + context.GetText());
        }

        public void ExitEncryption_mechanism(TSqlParser.Encryption_mechanismContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitEncryption_mechanism = " + context.GetText());
            }
        }

        public void EnterDecryption_mechanism(TSqlParser.Decryption_mechanismContext context)
        {
            Debug.WriteLine("EnterDecryption_mechanism = " + context.GetText());
        }

        public void ExitDecryption_mechanism(TSqlParser.Decryption_mechanismContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDecryption_mechanism = " + context.GetText());
            }
        }

        public void EnterGrant_permission(TSqlParser.Grant_permissionContext context)
        {
            Debug.WriteLine("EnterGrant_permission = " + context.GetText());
        }

        public void ExitGrant_permission(TSqlParser.Grant_permissionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitGrant_permission = " + context.GetText());
            }
        }

        public void EnterSet_statement(TSqlParser.Set_statementContext context)
        {
            Debug.WriteLine("EnterSet_statement = " + context.GetText());
        }

        public void ExitSet_statement(TSqlParser.Set_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSet_statement = " + context.GetText());
            }
        }

        public void EnterTransaction_statement(TSqlParser.Transaction_statementContext context)
        {
            Debug.WriteLine("EnterTransaction_statement = " + context.GetText());
        }

        public void ExitTransaction_statement(TSqlParser.Transaction_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitTransaction_statement = " + context.GetText());
            }
        }

        public void EnterGo_statement(TSqlParser.Go_statementContext context)
        {
            Debug.WriteLine("EnterGo_statement = " + context.GetText());
        }

        public void ExitGo_statement(TSqlParser.Go_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitGo_statement = " + context.GetText());
            }
        }

        public void EnterUse_statement(TSqlParser.Use_statementContext context)
        {
            Debug.WriteLine("EnterUse_statement = " + context.GetText());
        }

        public void ExitUse_statement(TSqlParser.Use_statementContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitUse_statement = " + context.GetText());
            }
        }

        public void EnterDbcc_clause(TSqlParser.Dbcc_clauseContext context)
        {
            Debug.WriteLine("EnterDbcc_clause = " + context.GetText());
        }

        public void ExitDbcc_clause(TSqlParser.Dbcc_clauseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDbcc_clause = " + context.GetText());
            }
        }

        public void EnterDbcc_options(TSqlParser.Dbcc_optionsContext context)
        {
            Debug.WriteLine("EnterDbcc_options = " + context.GetText());
        }

        public void ExitDbcc_options(TSqlParser.Dbcc_optionsContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDbcc_options = " + context.GetText());
            }
        }

        public void EnterExecute_clause(TSqlParser.Execute_clauseContext context)
        {
            Debug.WriteLine("EnterExecute_clause = " + context.GetText());
        }

        public void ExitExecute_clause(TSqlParser.Execute_clauseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitExecute_clause = " + context.GetText());
            }
        }

        public void EnterDeclare_local(TSqlParser.Declare_localContext context)
        {
            Debug.WriteLine("EnterDeclare_local = " + context.GetText());
        }

        public void ExitDeclare_local(TSqlParser.Declare_localContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDeclare_local = " + context.GetText());
            }
        }

        public void EnterTable_type_definition(TSqlParser.Table_type_definitionContext context)
        {
            Debug.WriteLine("EnterTable_type_definition = " + context.GetText());
        }

        public void ExitTable_type_definition(TSqlParser.Table_type_definitionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitTable_type_definition = " + context.GetText());
            }
        }

        public void EnterXml_type_definition(TSqlParser.Xml_type_definitionContext context)
        {
            Debug.WriteLine("EnterXml_type_definition = " + context.GetText());
        }

        public void ExitXml_type_definition(TSqlParser.Xml_type_definitionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitXml_type_definition = " + context.GetText());
            }
        }

        public void EnterXml_schema_collection(TSqlParser.Xml_schema_collectionContext context)
        {
            Debug.WriteLine("EnterXml_schema_collection = " + context.GetText());
        }

        public void ExitXml_schema_collection(TSqlParser.Xml_schema_collectionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitXml_schema_collection = " + context.GetText());
            }
        }

        public void EnterColumn_def_table_constraints(TSqlParser.Column_def_table_constraintsContext context)
        {
            Debug.WriteLine("EnterColumn_def_table_constraints = " + context.GetText());
        }

        public void ExitColumn_def_table_constraints(TSqlParser.Column_def_table_constraintsContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitColumn_def_table_constraints = " + context.GetText());
            }
        }

        public void EnterColumn_def_table_constraint(TSqlParser.Column_def_table_constraintContext context)
        {
            Debug.WriteLine("EnterColumn_def_table_constraint = " + context.GetText());
        }

        public void ExitColumn_def_table_constraint(TSqlParser.Column_def_table_constraintContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitColumn_def_table_constraint = " + context.GetText());
            }
        }

        public void EnterColumn_definition(TSqlParser.Column_definitionContext context)
        {
            Debug.WriteLine("EnterColumn_definition = " + context.GetText());
        }

        public void ExitColumn_definition(TSqlParser.Column_definitionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitColumn_definition = " + context.GetText());
            }
        }

        public void EnterColumn_constraint(TSqlParser.Column_constraintContext context)
        {
            Debug.WriteLine("EnterColumn_constraint = " + context.GetText());
        }

        public void ExitColumn_constraint(TSqlParser.Column_constraintContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitColumn_constraint = " + context.GetText());
            }
        }

        public void EnterTable_constraint(TSqlParser.Table_constraintContext context)
        {
            Debug.WriteLine("EnterTable_constraint = " + context.GetText());
        }

        public void ExitTable_constraint(TSqlParser.Table_constraintContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitTable_constraint = " + context.GetText());
            }
        }

        public void EnterOn_delete(TSqlParser.On_deleteContext context)
        {
            Debug.WriteLine("EnterOn_delete = " + context.GetText());
        }

        public void ExitOn_delete(TSqlParser.On_deleteContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitOn_delete = " + context.GetText());
            }
        }

        public void EnterOn_update(TSqlParser.On_updateContext context)
        {
            Debug.WriteLine("EnterOn_update = " + context.GetText());
        }

        public void ExitOn_update(TSqlParser.On_updateContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitOn_update = " + context.GetText());
            }
        }

        public void EnterIndex_options(TSqlParser.Index_optionsContext context)
        {
            Debug.WriteLine("EnterIndex_options = " + context.GetText());
        }

        public void ExitIndex_options(TSqlParser.Index_optionsContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitIndex_options = " + context.GetText());
            }
        }

        public void EnterIndex_option(TSqlParser.Index_optionContext context)
        {
            Debug.WriteLine("EnterIndex_option = " + context.GetText());
        }

        public void ExitIndex_option(TSqlParser.Index_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitIndex_option = " + context.GetText());
            }
        }

        public void EnterDeclare_cursor(TSqlParser.Declare_cursorContext context)
        {
            Debug.WriteLine("EnterDeclare_cursor = " + context.GetText());
        }

        public void ExitDeclare_cursor(TSqlParser.Declare_cursorContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDeclare_cursor = " + context.GetText());
            }
        }

        public void EnterDeclare_set_cursor_common(TSqlParser.Declare_set_cursor_commonContext context)
        {
            Debug.WriteLine("EnterDeclare_set_cursor_common = " + context.GetText());
        }

        public void ExitDeclare_set_cursor_common(TSqlParser.Declare_set_cursor_commonContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDeclare_set_cursor_common = " + context.GetText());
            }
        }

        public void EnterDeclare_set_cursor_common_partial(TSqlParser.Declare_set_cursor_common_partialContext context)
        {
            Debug.WriteLine("EnterDeclare_set_cursor_common_partial = " + context.GetText());
        }

        public void ExitDeclare_set_cursor_common_partial(TSqlParser.Declare_set_cursor_common_partialContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDeclare_set_cursor_common_partial = " + context.GetText());
            }
        }

        public void EnterFetch_cursor(TSqlParser.Fetch_cursorContext context)
        {
            Debug.WriteLine("EnterFetch_cursor = " + context.GetText());
        }

        public void ExitFetch_cursor(TSqlParser.Fetch_cursorContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitFetch_cursor = " + context.GetText());
            }
        }

        public void EnterSet_special(TSqlParser.Set_specialContext context)
        {
            Debug.WriteLine("EnterSet_special = " + context.GetText());
        }

        public void ExitSet_special(TSqlParser.Set_specialContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSet_special = " + context.GetText());
            }
        }

        public void EnterConstant_LOCAL_ID(TSqlParser.Constant_LOCAL_IDContext context)
        {
            Debug.WriteLine("EnterConstant_LOCAL_ID = " + context.GetText());
        }

        public void ExitConstant_LOCAL_ID(TSqlParser.Constant_LOCAL_IDContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitConstant_LOCAL_ID = " + context.GetText());
            }
        }

        public void EnterExpression(TSqlParser.ExpressionContext context)
        {
            Debug.WriteLine("EnterExpression = " + context.GetText());
        }

        public void ExitExpression(TSqlParser.ExpressionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitExpression = " + context.GetText());
            }
        }

        public void EnterPrimitive_expression(TSqlParser.Primitive_expressionContext context)
        {
            Debug.WriteLine("EnterPrimitive_expression = " + context.GetText());
        }

        public void ExitPrimitive_expression(TSqlParser.Primitive_expressionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitPrimitive_expression = " + context.GetText());
            }
        }

        public void EnterCase_expression(TSqlParser.Case_expressionContext context)
        {
            Debug.WriteLine("EnterCase_expression = " + context.GetText());
        }

        public void ExitCase_expression(TSqlParser.Case_expressionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCase_expression = " + context.GetText());
            }
        }

        public void EnterUnary_operator_expression(TSqlParser.Unary_operator_expressionContext context)
        {
            Debug.WriteLine("EnterUnary_operator_expression = " + context.GetText());
        }

        public void ExitUnary_operator_expression(TSqlParser.Unary_operator_expressionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitUnary_operator_expression = " + context.GetText());
            }
        }

        public void EnterBracket_expression(TSqlParser.Bracket_expressionContext context)
        {
            Debug.WriteLine("EnterBracket_expression = " + context.GetText());
        }

        public void ExitBracket_expression(TSqlParser.Bracket_expressionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitBracket_expression = " + context.GetText());
            }
        }

        public void EnterConstant_expression(TSqlParser.Constant_expressionContext context)
        {
            Debug.WriteLine("EnterConstant_expression = " + context.GetText());
        }

        public void ExitConstant_expression(TSqlParser.Constant_expressionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitConstant_expression = " + context.GetText());
            }
        }

        public void EnterSubquery(TSqlParser.SubqueryContext context)
        {
            Debug.WriteLine("EnterSubquery = " + context.GetText());
        }

        public void ExitSubquery(TSqlParser.SubqueryContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSubquery = " + context.GetText());
            }
        }

        public void EnterWith_expression(TSqlParser.With_expressionContext context)
        {
            Debug.WriteLine("EnterWith_expression = " + context.GetText());
        }

        public void ExitWith_expression(TSqlParser.With_expressionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitWith_expression = " + context.GetText());
            }
        }

        public void EnterCommon_table_expression(TSqlParser.Common_table_expressionContext context)
        {
            Debug.WriteLine("EnterCommon_table_expression = " + context.GetText());
        }

        public void ExitCommon_table_expression(TSqlParser.Common_table_expressionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCommon_table_expression = " + context.GetText());
            }
        }

        public void EnterUpdate_elem(TSqlParser.Update_elemContext context)
        {
            Debug.WriteLine("EnterUpdate_elem = " + context.GetText());
        }

        public void ExitUpdate_elem(TSqlParser.Update_elemContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitUpdate_elem = " + context.GetText());
            }
        }

        public void EnterSearch_condition_list(TSqlParser.Search_condition_listContext context)
        {
            Debug.WriteLine("EnterSearch_condition_list = " + context.GetText());
        }

        public void ExitSearch_condition_list(TSqlParser.Search_condition_listContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSearch_condition_list = " + context.GetText());
            }
        }

        public void EnterSearch_condition(TSqlParser.Search_conditionContext context)
        {
            Debug.WriteLine("EnterSearch_condition = " + context.GetText());
        }

        public void ExitSearch_condition(TSqlParser.Search_conditionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSearch_condition = " + context.GetText());
            }
        }

        public void EnterSearch_condition_and(TSqlParser.Search_condition_andContext context)
        {
            Debug.WriteLine("EnterSearch_condition_and = " + context.GetText());
        }

        public void ExitSearch_condition_and(TSqlParser.Search_condition_andContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSearch_condition_and = " + context.GetText());
            }
        }

        public void EnterSearch_condition_not(TSqlParser.Search_condition_notContext context)
        {
            Debug.WriteLine("EnterSearch_condition_not = " + context.GetText());
        }

        public void ExitSearch_condition_not(TSqlParser.Search_condition_notContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSearch_condition_not = " + context.GetText());
            }
        }

        public void EnterPredicate(TSqlParser.PredicateContext context)
        {
            Debug.WriteLine("EnterPredicate = " + context.GetText());
        }

        public void ExitPredicate(TSqlParser.PredicateContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitPredicate = " + context.GetText());
            }
        }

        public void EnterQuery_expression(TSqlParser.Query_expressionContext context)
        {
            Debug.WriteLine("EnterQuery_expression = " + context.GetText());
        }

        public void ExitQuery_expression(TSqlParser.Query_expressionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitQuery_expression = " + context.GetText());
            }
        }

        public void EnterSql_union(TSqlParser.Sql_unionContext context)
        {
            Debug.WriteLine("EnterSql_union = " + context.GetText());
        }

        public void ExitSql_union(TSqlParser.Sql_unionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSql_union = " + context.GetText());
            }
        }

        public void EnterQuery_specification(TSqlParser.Query_specificationContext context)
        {
            Debug.WriteLine("EnterQuery_specification = " + context.GetText());
        }

        public void ExitQuery_specification(TSqlParser.Query_specificationContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitQuery_specification = " + context.GetText());
            }
        }

        public void EnterTop_clause(TSqlParser.Top_clauseContext context)
        {
            Debug.WriteLine("EnterTop_clause = " + context.GetText());
        }

        public void ExitTop_clause(TSqlParser.Top_clauseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitTop_clause = " + context.GetText());
            }
        }

        public void EnterTop_percent(TSqlParser.Top_percentContext context)
        {
            Debug.WriteLine("EnterTop_percent = " + context.GetText());
        }

        public void ExitTop_percent(TSqlParser.Top_percentContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitTop_percent = " + context.GetText());
            }
        }

        public void EnterTop_count(TSqlParser.Top_countContext context)
        {
            Debug.WriteLine("EnterTop_count = " + context.GetText());
        }

        public void ExitTop_count(TSqlParser.Top_countContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitTop_count = " + context.GetText());
            }
        }

        public void EnterOrder_by_clause(TSqlParser.Order_by_clauseContext context)
        {
            Debug.WriteLine("EnterOrder_by_clause = " + context.GetText());
        }

        public void ExitOrder_by_clause(TSqlParser.Order_by_clauseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitOrder_by_clause = " + context.GetText());
            }
        }

        public void EnterFor_clause(TSqlParser.For_clauseContext context)
        {
            Debug.WriteLine("EnterFor_clause = " + context.GetText());
        }

        public void ExitFor_clause(TSqlParser.For_clauseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitFor_clause = " + context.GetText());
            }
        }

        public void EnterXml_common_directives(TSqlParser.Xml_common_directivesContext context)
        {
            Debug.WriteLine("EnterXml_common_directives = " + context.GetText());
        }

        public void ExitXml_common_directives(TSqlParser.Xml_common_directivesContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitXml_common_directives = " + context.GetText());
            }
        }

        public void EnterOrder_by_expression(TSqlParser.Order_by_expressionContext context)
        {
            Debug.WriteLine("EnterOrder_by_expression = " + context.GetText());
        }

        public void ExitOrder_by_expression(TSqlParser.Order_by_expressionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitOrder_by_expression = " + context.GetText());
            }
        }

        public void EnterGroup_by_item(TSqlParser.Group_by_itemContext context)
        {
            Debug.WriteLine("EnterGroup_by_item = " + context.GetText());
        }

        public void ExitGroup_by_item(TSqlParser.Group_by_itemContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitGroup_by_item = " + context.GetText());
            }
        }

        public void EnterOption_clause(TSqlParser.Option_clauseContext context)
        {
            Debug.WriteLine("EnterOption_clause = " + context.GetText());
        }

        public void ExitOption_clause(TSqlParser.Option_clauseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitOption_clause = " + context.GetText());
            }
        }

        public void EnterOption(TSqlParser.OptionContext context)
        {
            Debug.WriteLine("EnterOption = " + context.GetText());
        }

        public void ExitOption(TSqlParser.OptionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitOption = " + context.GetText());
            }
        }

        public void EnterOptimize_for_arg(TSqlParser.Optimize_for_argContext context)
        {
            Debug.WriteLine("EnterOptimize_for_arg = " + context.GetText());
        }

        public void ExitOptimize_for_arg(TSqlParser.Optimize_for_argContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitOptimize_for_arg = " + context.GetText());
            }
        }

        public void EnterSelect_list(TSqlParser.Select_listContext context)
        {
            Debug.WriteLine("EnterSelect_list = " + context.GetText());
        }

        public void ExitSelect_list(TSqlParser.Select_listContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSelect_list = " + context.GetText());
            }
        }

        public void EnterUdt_method_arguments(TSqlParser.Udt_method_argumentsContext context)
        {
            Debug.WriteLine("EnterUdt_method_arguments = " + context.GetText());
        }

        public void ExitUdt_method_arguments(TSqlParser.Udt_method_argumentsContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitUdt_method_arguments = " + context.GetText());
            }
        }

        public void EnterAsterisk(TSqlParser.AsteriskContext context)
        {
            Debug.WriteLine("EnterAsterisk = " + context.GetText());
        }

        public void ExitAsterisk(TSqlParser.AsteriskContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAsterisk = " + context.GetText());
            }
        }

        public void EnterColumn_elem(TSqlParser.Column_elemContext context)
        {
            Debug.WriteLine("EnterColumn_elem = " + context.GetText());
        }

        public void ExitColumn_elem(TSqlParser.Column_elemContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitColumn_elem = " + context.GetText());
            }
        }

        public void EnterUdt_elem(TSqlParser.Udt_elemContext context)
        {
            Debug.WriteLine("EnterUdt_elem = " + context.GetText());
        }

        public void ExitUdt_elem(TSqlParser.Udt_elemContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitUdt_elem = " + context.GetText());
            }
        }

        public void EnterExpression_elem(TSqlParser.Expression_elemContext context)
        {
            Debug.WriteLine("EnterExpression_elem = " + context.GetText());
        }

        public void ExitExpression_elem(TSqlParser.Expression_elemContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitExpression_elem = " + context.GetText());
            }
        }

        public void EnterSelect_list_elem(TSqlParser.Select_list_elemContext context)
        {
            Debug.WriteLine("EnterSelect_list_elem = " + context.GetText());
        }

        public void ExitSelect_list_elem(TSqlParser.Select_list_elemContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSelect_list_elem = " + context.GetText());
            }
        }

        public void EnterTable_sources(TSqlParser.Table_sourcesContext context)
        {
            Debug.WriteLine("EnterTable_sources = " + context.GetText());
        }

        public void ExitTable_sources(TSqlParser.Table_sourcesContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitTable_sources = " + context.GetText());
            }
        }

        public void EnterTable_source(TSqlParser.Table_sourceContext context)
        {
            Debug.WriteLine("EnterTable_source = " + context.GetText());
        }

        public void ExitTable_source(TSqlParser.Table_sourceContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitTable_source = " + context.GetText());
            }
        }

        public void EnterTable_source_item_joined(TSqlParser.Table_source_item_joinedContext context)
        {
            Debug.WriteLine("EnterTable_source_item_joined = " + context.GetText());
        }

        public void ExitTable_source_item_joined(TSqlParser.Table_source_item_joinedContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitTable_source_item_joined = " + context.GetText());
            }
        }

        public void EnterTable_source_item(TSqlParser.Table_source_itemContext context)
        {
            Debug.WriteLine("EnterTable_source_item = " + context.GetText());
        }

        public void ExitTable_source_item(TSqlParser.Table_source_itemContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitTable_source_item = " + context.GetText());
            }
        }

        public void EnterOpen_xml(TSqlParser.Open_xmlContext context)
        {
            Debug.WriteLine("EnterOpen_xml = " + context.GetText());
        }

        public void ExitOpen_xml(TSqlParser.Open_xmlContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitOpen_xml = " + context.GetText());
            }
        }

        public void EnterSchema_declaration(TSqlParser.Schema_declarationContext context)
        {
            Debug.WriteLine("EnterSchema_declaration = " + context.GetText());
        }

        public void ExitSchema_declaration(TSqlParser.Schema_declarationContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSchema_declaration = " + context.GetText());
            }
        }

        public void EnterColumn_declaration(TSqlParser.Column_declarationContext context)
        {
            Debug.WriteLine("EnterColumn_declaration = " + context.GetText());
        }

        public void ExitColumn_declaration(TSqlParser.Column_declarationContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitColumn_declaration = " + context.GetText());
            }
        }

        public void EnterChange_table(TSqlParser.Change_tableContext context)
        {
            Debug.WriteLine("EnterChange_table = " + context.GetText());
        }

        public void ExitChange_table(TSqlParser.Change_tableContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitChange_table = " + context.GetText());
            }
        }

        public void EnterJoin_part(TSqlParser.Join_partContext context)
        {
            Debug.WriteLine("EnterJoin_part = " + context.GetText());
        }

        public void ExitJoin_part(TSqlParser.Join_partContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitJoin_part = " + context.GetText());
            }
        }

        public void EnterPivot_clause(TSqlParser.Pivot_clauseContext context)
        {
            Debug.WriteLine("EnterPivot_clause = " + context.GetText());
        }

        public void ExitPivot_clause(TSqlParser.Pivot_clauseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitPivot_clause = " + context.GetText());
            }
        }

        public void EnterUnpivot_clause(TSqlParser.Unpivot_clauseContext context)
        {
            Debug.WriteLine("EnterUnpivot_clause = " + context.GetText());
        }

        public void ExitUnpivot_clause(TSqlParser.Unpivot_clauseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitUnpivot_clause = " + context.GetText());
            }
        }

        public void EnterFull_column_name_list(TSqlParser.Full_column_name_listContext context)
        {
            Debug.WriteLine("EnterFull_column_name_list = " + context.GetText());
        }

        public void ExitFull_column_name_list(TSqlParser.Full_column_name_listContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitFull_column_name_list = " + context.GetText());
            }
        }

        public void EnterTable_name_with_hint(TSqlParser.Table_name_with_hintContext context)
        {
            Debug.WriteLine("EnterTable_name_with_hint = " + context.GetText());
        }

        public void ExitTable_name_with_hint(TSqlParser.Table_name_with_hintContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitTable_name_with_hint = " + context.GetText());
            }
        }

        public void EnterRowset_function(TSqlParser.Rowset_functionContext context)
        {
            Debug.WriteLine("EnterRowset_function = " + context.GetText());
        }

        public void ExitRowset_function(TSqlParser.Rowset_functionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitRowset_function = " + context.GetText());
            }
        }

        public void EnterBulk_option(TSqlParser.Bulk_optionContext context)
        {
            Debug.WriteLine("EnterBulk_option = " + context.GetText());
        }

        public void ExitBulk_option(TSqlParser.Bulk_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitBulk_option = " + context.GetText());
            }
        }

        public void EnterDerived_table(TSqlParser.Derived_tableContext context)
        {
            Debug.WriteLine("EnterDerived_table = " + context.GetText());
        }

        public void ExitDerived_table(TSqlParser.Derived_tableContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDerived_table = " + context.GetText());
            }
        }

        public void EnterRANKING_WINDOWED_FUNC(TSqlParser.RANKING_WINDOWED_FUNCContext context)
        {
            Debug.WriteLine("EnterRANKING_WINDOWED_FUNC = " + context.GetText());
        }

        public void ExitRANKING_WINDOWED_FUNC(TSqlParser.RANKING_WINDOWED_FUNCContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitRANKING_WINDOWED_FUNC = " + context.GetText());
            }
        }

        public void EnterAGGREGATE_WINDOWED_FUNC(TSqlParser.AGGREGATE_WINDOWED_FUNCContext context)
        {
            Debug.WriteLine("EnterAGGREGATE_WINDOWED_FUNC = " + context.GetText());
        }

        public void ExitAGGREGATE_WINDOWED_FUNC(TSqlParser.AGGREGATE_WINDOWED_FUNCContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAGGREGATE_WINDOWED_FUNC = " + context.GetText());
            }
        }

        public void EnterANALYTIC_WINDOWED_FUNC(TSqlParser.ANALYTIC_WINDOWED_FUNCContext context)
        {
            Debug.WriteLine("EnterANALYTIC_WINDOWED_FUNC = " + context.GetText());
        }

        public void ExitANALYTIC_WINDOWED_FUNC(TSqlParser.ANALYTIC_WINDOWED_FUNCContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitANALYTIC_WINDOWED_FUNC = " + context.GetText());
            }
        }

        public void EnterSCALAR_FUNCTION(TSqlParser.SCALAR_FUNCTIONContext context)
        {
            Debug.WriteLine("EnterSCALAR_FUNCTION = " + context.GetText());
        }

        public void ExitSCALAR_FUNCTION(TSqlParser.SCALAR_FUNCTIONContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSCALAR_FUNCTION = " + context.GetText());
            }
        }

        public void EnterBINARY_CHECKSUM(TSqlParser.BINARY_CHECKSUMContext context)
        {
            Debug.WriteLine("EnterBINARY_CHECKSUM = " + context.GetText());
        }

        public void ExitBINARY_CHECKSUM(TSqlParser.BINARY_CHECKSUMContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitBINARY_CHECKSUM = " + context.GetText());
            }
        }

        public void EnterCAST(TSqlParser.CASTContext context)
        {
            Debug.WriteLine("EnterCAST = " + context.GetText());
        }

        public void ExitCAST(TSqlParser.CASTContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCAST = " + context.GetText());
            }
        }

        public void EnterCONVERT(TSqlParser.CONVERTContext context)
        {
            Debug.WriteLine("EnterCONVERT = " + context.GetText());
        }

        public void ExitCONVERT(TSqlParser.CONVERTContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCONVERT = " + context.GetText());
            }
        }

        public void EnterCHECKSUM(TSqlParser.CHECKSUMContext context)
        {
            Debug.WriteLine("EnterCHECKSUM = " + context.GetText());
        }

        public void ExitCHECKSUM(TSqlParser.CHECKSUMContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCHECKSUM = " + context.GetText());
            }
        }

        public void EnterCOALESCE(TSqlParser.COALESCEContext context)
        {
            Debug.WriteLine("EnterCOALESCE = " + context.GetText());
        }

        public void ExitCOALESCE(TSqlParser.COALESCEContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCOALESCE = " + context.GetText());
            }
        }

        public void EnterCURRENT_TIMESTAMP(TSqlParser.CURRENT_TIMESTAMPContext context)
        {
            Debug.WriteLine("EnterCURRENT_TIMESTAMP = " + context.GetText());
        }

        public void ExitCURRENT_TIMESTAMP(TSqlParser.CURRENT_TIMESTAMPContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCURRENT_TIMESTAMP = " + context.GetText());
            }
        }

        public void EnterCURRENT_USER(TSqlParser.CURRENT_USERContext context)
        {
            Debug.WriteLine("EnterCURRENT_USER = " + context.GetText());
        }

        public void ExitCURRENT_USER(TSqlParser.CURRENT_USERContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCURRENT_USER = " + context.GetText());
            }
        }

        public void EnterDATEADD(TSqlParser.DATEADDContext context)
        {
            Debug.WriteLine("EnterDATEADD = " + context.GetText());
        }

        public void ExitDATEADD(TSqlParser.DATEADDContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDATEADD = " + context.GetText());
            }
        }

        public void EnterDATEDIFF(TSqlParser.DATEDIFFContext context)
        {
            Debug.WriteLine("EnterDATEDIFF = " + context.GetText());
        }

        public void ExitDATEDIFF(TSqlParser.DATEDIFFContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDATEDIFF = " + context.GetText());
            }
        }

        public void EnterDATENAME(TSqlParser.DATENAMEContext context)
        {
            Debug.WriteLine("EnterDATENAME = " + context.GetText());
        }

        public void ExitDATENAME(TSqlParser.DATENAMEContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDATENAME = " + context.GetText());
            }
        }

        public void EnterDATEPART(TSqlParser.DATEPARTContext context)
        {
            Debug.WriteLine("EnterDATEPART = " + context.GetText());
        }

        public void ExitDATEPART(TSqlParser.DATEPARTContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDATEPART = " + context.GetText());
            }
        }

        public void EnterGETDATE(TSqlParser.GETDATEContext context)
        {
            Debug.WriteLine("EnterGETDATE = " + context.GetText());
        }

        public void ExitGETDATE(TSqlParser.GETDATEContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitGETDATE = " + context.GetText());
            }
        }

        public void EnterGETUTCDATE(TSqlParser.GETUTCDATEContext context)
        {
            Debug.WriteLine("EnterGETUTCDATE = " + context.GetText());
        }

        public void ExitGETUTCDATE(TSqlParser.GETUTCDATEContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitGETUTCDATE = " + context.GetText());
            }
        }

        public void EnterIDENTITY(TSqlParser.IDENTITYContext context)
        {
            Debug.WriteLine("EnterIDENTITY = " + context.GetText());
        }

        public void ExitIDENTITY(TSqlParser.IDENTITYContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitIDENTITY = " + context.GetText());
            }
        }

        public void EnterMIN_ACTIVE_ROWVERSION(TSqlParser.MIN_ACTIVE_ROWVERSIONContext context)
        {
            Debug.WriteLine("EnterMIN_ACTIVE_ROWVERSION = " + context.GetText());
        }

        public void ExitMIN_ACTIVE_ROWVERSION(TSqlParser.MIN_ACTIVE_ROWVERSIONContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitMIN_ACTIVE_ROWVERSION = " + context.GetText());
            }
        }

        public void EnterNULLIF(TSqlParser.NULLIFContext context)
        {
            Debug.WriteLine("EnterNULLIF = " + context.GetText());
        }

        public void ExitNULLIF(TSqlParser.NULLIFContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitNULLIF = " + context.GetText());
            }
        }

        public void EnterSTUFF(TSqlParser.STUFFContext context)
        {
            Debug.WriteLine("EnterSTUFF = " + context.GetText());
        }

        public void ExitSTUFF(TSqlParser.STUFFContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSTUFF = " + context.GetText());
            }
        }

        public void EnterSESSION_USER(TSqlParser.SESSION_USERContext context)
        {
            Debug.WriteLine("EnterSESSION_USER = " + context.GetText());
        }

        public void ExitSESSION_USER(TSqlParser.SESSION_USERContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSESSION_USER = " + context.GetText());
            }
        }

        public void EnterSYSTEM_USER(TSqlParser.SYSTEM_USERContext context)
        {
            Debug.WriteLine("EnterSYSTEM_USER = " + context.GetText());
        }

        public void ExitSYSTEM_USER(TSqlParser.SYSTEM_USERContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSYSTEM_USER = " + context.GetText());
            }
        }

        public void EnterISNULL(TSqlParser.ISNULLContext context)
        {
            Debug.WriteLine("EnterISNULL = " + context.GetText());
        }

        public void ExitISNULL(TSqlParser.ISNULLContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitISNULL = " + context.GetText());
            }
        }

        public void EnterXML_DATA_TYPE_FUNC(TSqlParser.XML_DATA_TYPE_FUNCContext context)
        {
            Debug.WriteLine("EnterXML_DATA_TYPE_FUNC = " + context.GetText());
        }

        public void ExitXML_DATA_TYPE_FUNC(TSqlParser.XML_DATA_TYPE_FUNCContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitXML_DATA_TYPE_FUNC = " + context.GetText());
            }
        }

        public void EnterXml_data_type_methods(TSqlParser.Xml_data_type_methodsContext context)
        {
            Debug.WriteLine("EnterXml_data_type_methods = " + context.GetText());
        }

        public void ExitXml_data_type_methods(TSqlParser.Xml_data_type_methodsContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitXml_data_type_methods = " + context.GetText());
            }
        }

        public void EnterValue_method(TSqlParser.Value_methodContext context)
        {
            Debug.WriteLine("EnterValue_method = " + context.GetText());
        }

        public void ExitValue_method(TSqlParser.Value_methodContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitValue_method = " + context.GetText());
            }
        }

        public void EnterQuery_method(TSqlParser.Query_methodContext context)
        {
            Debug.WriteLine("EnterQuery_method = " + context.GetText());
        }

        public void ExitQuery_method(TSqlParser.Query_methodContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitQuery_method = " + context.GetText());
            }
        }

        public void EnterExist_method(TSqlParser.Exist_methodContext context)
        {
            Debug.WriteLine("EnterExist_method = " + context.GetText());
        }

        public void ExitExist_method(TSqlParser.Exist_methodContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitExist_method = " + context.GetText());
            }
        }

        public void EnterModify_method(TSqlParser.Modify_methodContext context)
        {
            Debug.WriteLine("EnterModify_method = " + context.GetText());
        }

        public void ExitModify_method(TSqlParser.Modify_methodContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitModify_method = " + context.GetText());
            }
        }

        public void EnterNodes_method(TSqlParser.Nodes_methodContext context)
        {
            Debug.WriteLine("EnterNodes_method = " + context.GetText());
        }

        public void ExitNodes_method(TSqlParser.Nodes_methodContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitNodes_method = " + context.GetText());
            }
        }

        public void EnterSwitch_section(TSqlParser.Switch_sectionContext context)
        {
            Debug.WriteLine("EnterSwitch_section = " + context.GetText());
        }

        public void ExitSwitch_section(TSqlParser.Switch_sectionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSwitch_section = " + context.GetText());
            }
        }

        public void EnterSwitch_search_condition_section(TSqlParser.Switch_search_condition_sectionContext context)
        {
            Debug.WriteLine("EnterSwitch_search_condition_section = " + context.GetText());
        }

        public void ExitSwitch_search_condition_section(TSqlParser.Switch_search_condition_sectionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSwitch_search_condition_section = " + context.GetText());
            }
        }

        public void EnterAs_column_alias(TSqlParser.As_column_aliasContext context)
        {
            Debug.WriteLine("EnterAs_column_alias = " + context.GetText());
        }

        public void ExitAs_column_alias(TSqlParser.As_column_aliasContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAs_column_alias = " + context.GetText());
            }
        }

        public void EnterAs_table_alias(TSqlParser.As_table_aliasContext context)
        {
            Debug.WriteLine("EnterAs_table_alias = " + context.GetText());
        }

        public void ExitAs_table_alias(TSqlParser.As_table_aliasContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAs_table_alias = " + context.GetText());
            }
        }

        public void EnterTable_alias(TSqlParser.Table_aliasContext context)
        {
            Debug.WriteLine("EnterTable_alias = " + context.GetText());
        }

        public void ExitTable_alias(TSqlParser.Table_aliasContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitTable_alias = " + context.GetText());
            }
        }

        public void EnterWith_table_hints(TSqlParser.With_table_hintsContext context)
        {
            Debug.WriteLine("EnterWith_table_hints = " + context.GetText());
        }

        public void ExitWith_table_hints(TSqlParser.With_table_hintsContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitWith_table_hints = " + context.GetText());
            }
        }

        public void EnterInsert_with_table_hints(TSqlParser.Insert_with_table_hintsContext context)
        {
            Debug.WriteLine("EnterInsert_with_table_hints = " + context.GetText());
        }

        public void ExitInsert_with_table_hints(TSqlParser.Insert_with_table_hintsContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitInsert_with_table_hints = " + context.GetText());
            }
        }

        public void EnterTable_hint(TSqlParser.Table_hintContext context)
        {
            Debug.WriteLine("EnterTable_hint = " + context.GetText());
        }

        public void ExitTable_hint(TSqlParser.Table_hintContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitTable_hint = " + context.GetText());
            }
        }

        public void EnterIndex_value(TSqlParser.Index_valueContext context)
        {
            Debug.WriteLine("EnterIndex_value = " + context.GetText());
        }

        public void ExitIndex_value(TSqlParser.Index_valueContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitIndex_value = " + context.GetText());
            }
        }

        public void EnterColumn_alias_list(TSqlParser.Column_alias_listContext context)
        {
            Debug.WriteLine("EnterColumn_alias_list = " + context.GetText());
        }

        public void ExitColumn_alias_list(TSqlParser.Column_alias_listContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitColumn_alias_list = " + context.GetText());
            }
        }

        public void EnterColumn_alias(TSqlParser.Column_aliasContext context)
        {
            Debug.WriteLine("EnterColumn_alias = " + context.GetText());
        }

        public void ExitColumn_alias(TSqlParser.Column_aliasContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitColumn_alias = " + context.GetText());
            }
        }

        public void EnterTable_value_constructor(TSqlParser.Table_value_constructorContext context)
        {
            Debug.WriteLine("EnterTable_value_constructor = " + context.GetText());
        }

        public void ExitTable_value_constructor(TSqlParser.Table_value_constructorContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitTable_value_constructor = " + context.GetText());
            }
        }

        public void EnterExpression_list(TSqlParser.Expression_listContext context)
        {
            Debug.WriteLine("EnterExpression_list = " + context.GetText());
        }

        public void ExitExpression_list(TSqlParser.Expression_listContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitExpression_list = " + context.GetText());
            }
        }

        public void EnterRanking_windowed_function(TSqlParser.Ranking_windowed_functionContext context)
        {
            Debug.WriteLine("EnterRanking_windowed_function = " + context.GetText());
        }

        public void ExitRanking_windowed_function(TSqlParser.Ranking_windowed_functionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitRanking_windowed_function = " + context.GetText());
            }
        }

        public void EnterAggregate_windowed_function(TSqlParser.Aggregate_windowed_functionContext context)
        {
            Debug.WriteLine("EnterAggregate_windowed_function = " + context.GetText());
        }

        public void ExitAggregate_windowed_function(TSqlParser.Aggregate_windowed_functionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAggregate_windowed_function = " + context.GetText());
            }
        }

        public void EnterAnalytic_windowed_function(TSqlParser.Analytic_windowed_functionContext context)
        {
            Debug.WriteLine("EnterAnalytic_windowed_function = " + context.GetText());
        }

        public void ExitAnalytic_windowed_function(TSqlParser.Analytic_windowed_functionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAnalytic_windowed_function = " + context.GetText());
            }
        }

        public void EnterAll_distinct_expression(TSqlParser.All_distinct_expressionContext context)
        {
            Debug.WriteLine("EnterAll_distinct_expression = " + context.GetText());
        }

        public void ExitAll_distinct_expression(TSqlParser.All_distinct_expressionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAll_distinct_expression = " + context.GetText());
            }
        }

        public void EnterOver_clause(TSqlParser.Over_clauseContext context)
        {
            Debug.WriteLine("EnterOver_clause = " + context.GetText());
        }

        public void ExitOver_clause(TSqlParser.Over_clauseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitOver_clause = " + context.GetText());
            }
        }

        public void EnterRow_or_range_clause(TSqlParser.Row_or_range_clauseContext context)
        {
            Debug.WriteLine("EnterRow_or_range_clause = " + context.GetText());
        }

        public void ExitRow_or_range_clause(TSqlParser.Row_or_range_clauseContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitRow_or_range_clause = " + context.GetText());
            }
        }

        public void EnterWindow_frame_extent(TSqlParser.Window_frame_extentContext context)
        {
            Debug.WriteLine("EnterWindow_frame_extent = " + context.GetText());
        }

        public void ExitWindow_frame_extent(TSqlParser.Window_frame_extentContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitWindow_frame_extent = " + context.GetText());
            }
        }

        public void EnterWindow_frame_bound(TSqlParser.Window_frame_boundContext context)
        {
            Debug.WriteLine("EnterWindow_frame_bound = " + context.GetText());
        }

        public void ExitWindow_frame_bound(TSqlParser.Window_frame_boundContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitWindow_frame_bound = " + context.GetText());
            }
        }

        public void EnterWindow_frame_preceding(TSqlParser.Window_frame_precedingContext context)
        {
            Debug.WriteLine("EnterWindow_frame_preceding = " + context.GetText());
        }

        public void ExitWindow_frame_preceding(TSqlParser.Window_frame_precedingContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitWindow_frame_preceding = " + context.GetText());
            }
        }

        public void EnterWindow_frame_following(TSqlParser.Window_frame_followingContext context)
        {
            Debug.WriteLine("EnterWindow_frame_following = " + context.GetText());
        }

        public void ExitWindow_frame_following(TSqlParser.Window_frame_followingContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitWindow_frame_following = " + context.GetText());
            }
        }

        public void EnterCreate_database_option(TSqlParser.Create_database_optionContext context)
        {
            Debug.WriteLine("EnterCreate_database_option = " + context.GetText());
        }

        public void ExitCreate_database_option(TSqlParser.Create_database_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCreate_database_option = " + context.GetText());
            }
        }

        public void EnterDatabase_filestream_option(TSqlParser.Database_filestream_optionContext context)
        {
            Debug.WriteLine("EnterDatabase_filestream_option = " + context.GetText());
        }

        public void ExitDatabase_filestream_option(TSqlParser.Database_filestream_optionContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDatabase_filestream_option = " + context.GetText());
            }
        }

        public void EnterDatabase_file_spec(TSqlParser.Database_file_specContext context)
        {
            Debug.WriteLine("EnterDatabase_file_spec = " + context.GetText());
        }

        public void ExitDatabase_file_spec(TSqlParser.Database_file_specContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDatabase_file_spec = " + context.GetText());
            }
        }

        public void EnterFile_group(TSqlParser.File_groupContext context)
        {
            Debug.WriteLine("EnterFile_group = " + context.GetText());
        }

        public void ExitFile_group(TSqlParser.File_groupContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitFile_group = " + context.GetText());
            }
        }

        public void EnterFile_spec(TSqlParser.File_specContext context)
        {
            Debug.WriteLine("EnterFile_spec = " + context.GetText());
        }

        public void ExitFile_spec(TSqlParser.File_specContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitFile_spec = " + context.GetText());
            }
        }

        public void EnterEntity_name(TSqlParser.Entity_nameContext context)
        {
            Debug.WriteLine("EnterEntity_name = " + context.GetText());
        }

        public void ExitEntity_name(TSqlParser.Entity_nameContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitEntity_name = " + context.GetText());
            }
        }

        public void EnterEntity_name_for_azure_dw(TSqlParser.Entity_name_for_azure_dwContext context)
        {
            Debug.WriteLine("EnterEntity_name_for_azure_dw = " + context.GetText());
        }

        public void ExitEntity_name_for_azure_dw(TSqlParser.Entity_name_for_azure_dwContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitEntity_name_for_azure_dw = " + context.GetText());
            }
        }

        public void EnterEntity_name_for_parallel_dw(TSqlParser.Entity_name_for_parallel_dwContext context)
        {
            Debug.WriteLine("EnterEntity_name_for_parallel_dw = " + context.GetText());
        }

        public void ExitEntity_name_for_parallel_dw(TSqlParser.Entity_name_for_parallel_dwContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitEntity_name_for_parallel_dw = " + context.GetText());
            }
        }

        public void EnterFull_table_name(TSqlParser.Full_table_nameContext context)
        {
            Debug.WriteLine("EnterFull_table_name = " + context.GetText());
        }

        public void ExitFull_table_name(TSqlParser.Full_table_nameContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitFull_table_name = " + context.GetText());
            }
        }

        public void EnterTable_name(TSqlParser.Table_nameContext context)
        {
            Debug.WriteLine("EnterTable_name = " + context.GetText());
        }

        public void ExitTable_name(TSqlParser.Table_nameContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitTable_name = " + context.GetText());
            }
        }

        public void EnterSimple_name(TSqlParser.Simple_nameContext context)
        {
            Debug.WriteLine("EnterSimple_name = " + context.GetText());
        }

        public void ExitSimple_name(TSqlParser.Simple_nameContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSimple_name = " + context.GetText());
            }
        }

        public void EnterFunc_proc_name(TSqlParser.Func_proc_nameContext context)
        {
            Debug.WriteLine("EnterFunc_proc_name = " + context.GetText());
        }

        public void ExitFunc_proc_name(TSqlParser.Func_proc_nameContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitFunc_proc_name = " + context.GetText());
            }
        }

        public void EnterDdl_object(TSqlParser.Ddl_objectContext context)
        {
            Debug.WriteLine("EnterDdl_object = " + context.GetText());
        }

        public void ExitDdl_object(TSqlParser.Ddl_objectContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDdl_object = " + context.GetText());
            }
        }

        public void EnterFull_column_name(TSqlParser.Full_column_nameContext context)
        {
            Debug.WriteLine("EnterFull_column_name = " + context.GetText());
        }

        public void ExitFull_column_name(TSqlParser.Full_column_nameContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitFull_column_name = " + context.GetText());
            }
        }

        public void EnterColumn_name_list_with_order(TSqlParser.Column_name_list_with_orderContext context)
        {
            Debug.WriteLine("EnterColumn_name_list_with_order = " + context.GetText());
        }

        public void ExitColumn_name_list_with_order(TSqlParser.Column_name_list_with_orderContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitColumn_name_list_with_order = " + context.GetText());
            }
        }

        public void EnterColumn_name_list(TSqlParser.Column_name_listContext context)
        {
            Debug.WriteLine("EnterColumn_name_list = " + context.GetText());
        }

        public void ExitColumn_name_list(TSqlParser.Column_name_listContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitColumn_name_list = " + context.GetText());
            }
        }

        public void EnterCursor_name(TSqlParser.Cursor_nameContext context)
        {
            Debug.WriteLine("EnterCursor_name = " + context.GetText());
        }

        public void ExitCursor_name(TSqlParser.Cursor_nameContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitCursor_name = " + context.GetText());
            }
        }

        public void EnterOn_off(TSqlParser.On_offContext context)
        {
            Debug.WriteLine("EnterOn_off = " + context.GetText());
        }

        public void ExitOn_off(TSqlParser.On_offContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitOn_off = " + context.GetText());
            }
        }

        public void EnterClustered(TSqlParser.ClusteredContext context)
        {
            Debug.WriteLine("EnterClustered = " + context.GetText());
        }

        public void ExitClustered(TSqlParser.ClusteredContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitClustered = " + context.GetText());
            }
        }

        public void EnterNull_notnull(TSqlParser.Null_notnullContext context)
        {
            Debug.WriteLine("EnterNull_notnull = " + context.GetText());
        }

        public void ExitNull_notnull(TSqlParser.Null_notnullContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitNull_notnull = " + context.GetText());
            }
        }

        public void EnterNull_or_default(TSqlParser.Null_or_defaultContext context)
        {
            Debug.WriteLine("EnterNull_or_default = " + context.GetText());
        }

        public void ExitNull_or_default(TSqlParser.Null_or_defaultContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitNull_or_default = " + context.GetText());
            }
        }

        public void EnterScalar_function_name(TSqlParser.Scalar_function_nameContext context)
        {
            Debug.WriteLine("EnterScalar_function_name = " + context.GetText());
        }

        public void ExitScalar_function_name(TSqlParser.Scalar_function_nameContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitScalar_function_name = " + context.GetText());
            }
        }

        public void EnterBegin_conversation_timer(TSqlParser.Begin_conversation_timerContext context)
        {
            Debug.WriteLine("EnterBegin_conversation_timer = " + context.GetText());
        }

        public void ExitBegin_conversation_timer(TSqlParser.Begin_conversation_timerContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitBegin_conversation_timer = " + context.GetText());
            }
        }

        public void EnterBegin_conversation_dialog(TSqlParser.Begin_conversation_dialogContext context)
        {
            Debug.WriteLine("EnterBegin_conversation_dialog = " + context.GetText());
        }

        public void ExitBegin_conversation_dialog(TSqlParser.Begin_conversation_dialogContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitBegin_conversation_dialog = " + context.GetText());
            }
        }

        public void EnterContract_name(TSqlParser.Contract_nameContext context)
        {
            Debug.WriteLine("EnterContract_name = " + context.GetText());
        }

        public void ExitContract_name(TSqlParser.Contract_nameContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitContract_name = " + context.GetText());
            }
        }

        public void EnterService_name(TSqlParser.Service_nameContext context)
        {
            Debug.WriteLine("EnterService_name = " + context.GetText());
        }

        public void ExitService_name(TSqlParser.Service_nameContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitService_name = " + context.GetText());
            }
        }

        public void EnterEnd_conversation(TSqlParser.End_conversationContext context)
        {
            Debug.WriteLine("EnterEnd_conversation = " + context.GetText());
        }

        public void ExitEnd_conversation(TSqlParser.End_conversationContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitEnd_conversation = " + context.GetText());
            }
        }

        public void EnterWaitfor_conversation(TSqlParser.Waitfor_conversationContext context)
        {
            Debug.WriteLine("EnterWaitfor_conversation = " + context.GetText());
        }

        public void ExitWaitfor_conversation(TSqlParser.Waitfor_conversationContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitWaitfor_conversation = " + context.GetText());
            }
        }

        public void EnterGet_conversation(TSqlParser.Get_conversationContext context)
        {
            Debug.WriteLine("EnterGet_conversation = " + context.GetText());
        }

        public void ExitGet_conversation(TSqlParser.Get_conversationContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitGet_conversation = " + context.GetText());
            }
        }

        public void EnterQueue_id(TSqlParser.Queue_idContext context)
        {
            Debug.WriteLine("EnterQueue_id = " + context.GetText());
        }

        public void ExitQueue_id(TSqlParser.Queue_idContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitQueue_id = " + context.GetText());
            }
        }

        public void EnterSend_conversation(TSqlParser.Send_conversationContext context)
        {
            Debug.WriteLine("EnterSend_conversation = " + context.GetText());
        }

        public void ExitSend_conversation(TSqlParser.Send_conversationContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSend_conversation = " + context.GetText());
            }
        }

        public void EnterData_type(TSqlParser.Data_typeContext context)
        {
            Debug.WriteLine("EnterData_type = " + context.GetText());
        }

        public void ExitData_type(TSqlParser.Data_typeContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitData_type = " + context.GetText());
            }
        }

        public void EnterDefault_value(TSqlParser.Default_valueContext context)
        {
            Debug.WriteLine("EnterDefault_value = " + context.GetText());
        }

        public void ExitDefault_value(TSqlParser.Default_valueContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitDefault_value = " + context.GetText());
            }
        }

        public void EnterConstant(TSqlParser.ConstantContext context)
        {
            Debug.WriteLine("EnterConstant = " + context.GetText());
        }

        public void ExitConstant(TSqlParser.ConstantContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitConstant = " + context.GetText());
            }
        }

        public void EnterSign(TSqlParser.SignContext context)
        {
            Debug.WriteLine("EnterSign = " + context.GetText());
        }

        public void ExitSign(TSqlParser.SignContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSign = " + context.GetText());
            }
        }

        public void EnterId(TSqlParser.IdContext context)
        {
            Debug.WriteLine("EnterId = " + context.GetText());
        }

        public void ExitId(TSqlParser.IdContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitId = " + context.GetText());
            }
        }

        public void EnterSimple_id(TSqlParser.Simple_idContext context)
        {
            Debug.WriteLine("EnterSimple_id = " + context.GetText());
        }

        public void ExitSimple_id(TSqlParser.Simple_idContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitSimple_id = " + context.GetText());
            }
        }

        public void EnterComparison_operator(TSqlParser.Comparison_operatorContext context)
        {
            Debug.WriteLine("EnterComparison_operator = " + context.GetText());
        }

        public void ExitComparison_operator(TSqlParser.Comparison_operatorContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitComparison_operator = " + context.GetText());
            }
        }

        public void EnterAssignment_operator(TSqlParser.Assignment_operatorContext context)
        {
            Debug.WriteLine("EnterAssignment_operator = " + context.GetText());
        }

        public void ExitAssignment_operator(TSqlParser.Assignment_operatorContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitAssignment_operator = " + context.GetText());
            }
        }

        public void EnterFile_size(TSqlParser.File_sizeContext context)
        {
            Debug.WriteLine("EnterFile_size = " + context.GetText());
        }

        public void ExitFile_size(TSqlParser.File_sizeContext context)
        {
            if (_isViewExit)
            {
                Debug.WriteLine("ExitFile_size = " + context.GetText());
            }
        }
    }
}