# comandos compilar arquivos cmd
# constroi um assembly *.exe
csc /target:exe TesteApp.cs 

# constroi um assembly *.dll
csc /target:library TesteApp.cs

# constroi um module são diversos assemblys
csc /target:module 

#compilar
csc /target:exe
csc TesteApp.cs

#compilar mais de um arquivo
csc /r:System.Windows.Forms.dll TesteApp.cs HelloMessage.cs
csc /r:System.Windows.Forms.dll *.cs

#Arquivos de resposta c# rsp script para compilação de codigo