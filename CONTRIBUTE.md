#Getting the Lightcore solution up and running#

## Using local Sitecore instance ##

1. Fork / Clone
2. Unzip the **Website** folder from "Sitecore 8.1 rev. 151003.zip" into `.\src\Lightcore.Server.Sitecore.TestServer`
3. Unzip the **Website\bin** folder from "Sitecore 8.1 rev. 151003.zip" into `.\lib\Sitecore`
4. Undo any commits (the zip file overwrite the checked in Web.config)
5. Build
6. Setup IIS site with a binding on `lightcore-cm.local`
7. Browse `lightcore-cm.local` and log into Sitecore
8. Click revert database in the serialization tab
9. Do a full publish
10. CTRL + F5

## Using shared Sitecore instance ##

1. Fork / Clone
2. Use `http://lightcore-dev-website-cm.azurewebsites.net/` in /src/DemoWebsite/lightcore.Staging.json
3. CTRL + F5