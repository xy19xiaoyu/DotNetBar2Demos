DotNetBar uses the concept of “Satellite Assemblies” for localization.
Please see the “Resources in Applications” topic in Visual Studio Help
for more details about Satellite Assemblies.

Open the file DevComponents.DotNetBar.Strings.de.txt and translate the
text inside. Change the file name so it reflects your culture. In this
case you only need to change the .de. string and replace it with your
culture code. See CultureInfo Class for naming conventions. Compile
this into the Satellite Assembly and deploy it in subdirectory named
according to your culture code. In this sample DE subdirectory is used
for German version of Satellite Assembly.

Use Compile.bat to create Satellite Assembly. Make sure that you update
the paths in Compile.bat so they reflected the location of the utilities
on your drive. Do not forget to change the file names in Compile.bat to
reflect the names of the text files and compiled resource files that are
updated with your culture code.

Please consider sending us the translated text file so we can include
it into the DotNetBar base release. Send the translated file to:
dotnetbar@devcomponents.com

Thank you.
