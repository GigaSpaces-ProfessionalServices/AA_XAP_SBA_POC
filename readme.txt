Simple XAP SPA POC 

This sample project demonstrates the XAP event notification space based application.


The DataFeeder PU writes a series of messages to the XAP Spaces which are process by the DataProcessor which 
changes the processed attribute on the Common Data object to true.

In order to build the application, open the solution file GigaSpaces.Examples.ProcessingUnit.sln and update the reference to GigaSpaces.Core.dll which is located in the <XAP.NET Application>\NET v4.0\Bin folder. 

The Common project includes the data model and is used by the other projects.

The Feeder module sends the Data object to the space with the process property set to false.

The Processor module updates the processed property to true and responds to notifications requests from the Feeder modoule.

Once the references have been updated, rebuild the solution. The output should be sent to the Release subdirectory:

<PROJECT FOLDER>/Release/
DataProcessor
DataFeeder


Before deploying to you local XAP installation please note that XAP automatically deploys any PU applications 
in the <XAP APPLICATION>\NET v4.0\Deploy folder. Delete the DataFeeder and DataProcesser subdirectories from the Deploy folder.
However, you need to keep the Templates folder.


Open the powershell window to <XAP APPLICATION>\NET v4.0\Bin and start the Gigaspaces agent.
Execute ./gs-agent

Once the agent has started, open another powershell window to the same folder and start the XAP UI.
Execute ./gs-ui

Once the XAP UI is up, click on the 'Deploy Application' icon and browse to your 'Release' folder. In the 'Deployment Wizard' dialog,
check the 'Select directory only' checkbox. Next select the DataProcessor folder and click 'Deploy'. This will deploy the Processor PU and the embedded space. If the dialog says 'Successful Deployment', click 'Close'. Please refer snapshot2

Repeat the above step for the 'DataFeeder' folder. Please refer snapshot2.png

If you switch back the to the Powershell window in which you launched the gs-agent, you should see the log messages from the  application. 

You can also, browse the data in the XAP Ui. Please refer snapshots3.png and snapshot4.png.









