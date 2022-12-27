<# 
	Generate Plant-UML
	https://github.com/pierre3/PlantUmlClassDiagramGenerator
#>
Get-ChildItem -Path ..\ -Include *.puml -File -Recurse | foreach { $_.Delete()}
puml-gen ..\ -dir -createAssociation -allInOne
Get-ChildItem -Path ..\ -Include *.puml -File -Recurse