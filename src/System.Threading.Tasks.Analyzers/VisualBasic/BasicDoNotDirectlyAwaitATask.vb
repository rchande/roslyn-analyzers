' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Imports Microsoft.CodeAnalysis
Imports Microsoft.CodeAnalysis.Diagnostics
Imports Microsoft.CodeAnalysis.VisualBasic
Imports Microsoft.CodeAnalysis.VisualBasic.Syntax

Namespace System.Threading.Tasks.Analyzers   
    ''' <summary>
    ''' RS0003: Do not directly await a Task
    ''' </summary>
    <DiagnosticAnalyzer(LanguageNames.VisualBasic)>
    Public NotInheritable Class BasicDoNotDirectlyAwaitATaskAnalyzer
        Inherits DoNotDirectlyAwaitATaskAnalyzer

    End Class
End Namespace