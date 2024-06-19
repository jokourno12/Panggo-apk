# Command
1. instal dotnet
2. dotnet workload install android
4. dotnet workload list
5. goto: https://platform.uno/docs/articles/create-an-app-vscode.html?tabs=Wasm
6. cd panggo_apk
7. dotnet restore
8. dotnet build -c Release -p TargetFramework=net8.0-android
9. get file .apk in /panggo_apk/bin/Release/net8.0-android/com.companyname.panggo-Signed.apk
10. 