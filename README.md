This is a basic application that shows how to do basic tasks using C# talking to a Stohn Coin Node via RPC.  This same C# code can be used to make a REST API, or a Windows Service!  This code relies heavily on the already existing BitNet Bitcoin RPC Client.  It does not include every single Stohn Coin RPC Call but it should have a enough to get you started.  There is a section in one of the files that indicates where you can add more RPC method calls.  Since stohn Coin is based on Bitcoin a lot of the research can be done using Bitcoin RPC call code.

You will need to set up a Stohn Coin node on a linux machine somewhere in order for this application to communicate with a node. I don't think there are any public RPC nodes at the moment? But Instructions on making your own node can be found here:
https://stohncoin.org/how-to-install-a-stohn-coin-node-on-a-digital-ocean-server/
I was actually able to make a Stohn Coin node on my ubuntu machine by starting these instructions on step 5.

*NOTE: You may have to right click on the winform_project and select "Set As Startup Project". For some reason it picks the Code Class project as the startup project. Other than that it should compile right out the gate.

rowjelio@yahoo.com
