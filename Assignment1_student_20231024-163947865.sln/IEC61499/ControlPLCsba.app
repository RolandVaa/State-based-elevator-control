<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE SubAppType SYSTEM "../LibraryElement.dtd">
<SubAppType GUID="ce189526-a9f4-4718-be95-fa68f7c5f797" Name="ControlPLCsba" Comment="Subapplication " Namespace="Main">
  <Attribute Name="Configuration.FB.IDCounter" Value="11" />
  <Identification Standard="61499-2" />
  <VersionInfo Organization="nxtControl GmBH" Version="0.0" Author="vv263" Date="7/26/2023" Remarks="template" />
  <SubAppInterfaceList>
    <SubAppEventInputs>
      <SubAppEvent Name="INIT" />
      <SubAppEvent Name="REQ" />
    </SubAppEventInputs>
    <SubAppEventOutputs>
      <SubAppEvent Name="INITO" />
      <SubAppEvent Name="CNF" />
    </SubAppEventOutputs>
    <InputVars>
      <VarDeclaration Name="OnFloor0" Type="BOOL" Comment="Input event qualifier" />
      <VarDeclaration Name="OnFloor1" Type="BOOL" />
      <VarDeclaration Name="OnFloor2" Type="BOOL" />
      <VarDeclaration Name="ButtonAt0" Type="BOOL" />
      <VarDeclaration Name="ButtonAt1" Type="BOOL" />
      <VarDeclaration Name="ButtonAt2" Type="BOOL" />
      <VarDeclaration Name="ButtonFor0" Type="BOOL" />
      <VarDeclaration Name="ButtonFor1" Type="BOOL" />
      <VarDeclaration Name="ButtonFor2" Type="BOOL" />
      <VarDeclaration Name="DoorClosed0" Type="BOOL" />
      <VarDeclaration Name="DoorClosed1" Type="BOOL" />
      <VarDeclaration Name="DoorClosed2" Type="BOOL" />
      <VarDeclaration Name="DoorOpened0" Type="BOOL" />
      <VarDeclaration Name="DoorOpened1" Type="BOOL" />
      <VarDeclaration Name="DoorOpened2" Type="BOOL" />
    </InputVars>
    <OutputVars>
      <VarDeclaration Name="MoveUp" Type="BOOL" Comment="Output event qualifier" />
      <VarDeclaration Name="MoveDown" Type="BOOL" />
      <VarDeclaration Name="Open0" Type="BOOL" />
      <VarDeclaration Name="Open1" Type="BOOL" />
      <VarDeclaration Name="Open2" Type="BOOL" />
    </OutputVars>
  </SubAppInterfaceList>
  <SubAppNetwork>
    <FB ID="9" UID="6" Name="FB1" Type="PLCControl" x="2000" y="540" Namespace="Main" />
    <FB ID="10" Name="FB2" Type="E_DELAY" x="3800" y="660" Namespace="IEC61499.Standard" />
    <FB ID="11" Name="FB3" Type="E_CYCLE" x="600" y="620" Namespace="IEC61499.Standard">
      <Parameter Name="DT" Value="T#500ms" />
    </FB>
    <EventConnections>
      <Connection Source="FB1.INITO" Destination="INITO" />
      <Connection Source="FB1.CNF" Destination="CNF" />
      <Connection Source="INIT" Destination="FB1.INIT" />
      <Connection Source="FB1.Start_t1" Destination="FB2.START" />
      <Connection Source="FB2.EO" Destination="FB1.End_t1" dx1="48.5" dx2="90" dy="-340">
        <AvoidsNodes>false</AvoidsNodes>
      </Connection>
      <Connection Source="FB1.INITO" Destination="FB3.START" dx1="201.5835" dx2="50" dy="-110" />
      <Connection Source="FB3.EO" Destination="FB1.REQ">
        <Points>
          <Points>
            <X>235.375</X>
            <Y>165</Y>
          </Points>
          <Points>
            <X>247.5</X>
            <Y>165</Y>
          </Points>
          <Points>
            <X>247.5</X>
            <Y>172.5</Y>
          </Points>
          <Points>
            <X>342.5</X>
            <Y>172.5</Y>
          </Points>
          <Points>
            <X>342.5</X>
            <Y>160</Y>
          </Points>
          <Points>
            <X>495</X>
            <Y>160</Y>
          </Points>
        </Points>
      </Connection>
      <Connection Source="REQ" Destination="FB1.REQ" />
    </EventConnections>
    <DataConnections>
      <Connection Source="OnFloor0" Destination="FB1.OnFloor0" />
      <Connection Source="OnFloor1" Destination="FB1.OnFloor1" />
      <Connection Source="OnFloor2" Destination="FB1.OnFloor2" />
      <Connection Source="DoorClosed0" Destination="FB1.DoorClosed0" />
      <Connection Source="DoorClosed1" Destination="FB1.DoorClosed1" />
      <Connection Source="DoorClosed2" Destination="FB1.DoorClosed2" />
      <Connection Source="ButtonAt0" Destination="FB1.ButtonOn0" />
      <Connection Source="ButtonAt1" Destination="FB1.ButtonOn1" />
      <Connection Source="ButtonAt2" Destination="FB1.ButtonOn2" />
      <Connection Source="ButtonFor0" Destination="FB1.CabButton0" />
      <Connection Source="ButtonFor1" Destination="FB1.CabButton1" />
      <Connection Source="ButtonFor2" Destination="FB1.CabButton2" />
      <Connection Source="FB1.liftUp" Destination="MoveUp" />
      <Connection Source="FB1.liftDown" Destination="MoveDown" />
      <Connection Source="DoorOpened0" Destination="FB1.DoorOpened0" />
      <Connection Source="DoorOpened1" Destination="FB1.DoorOpened1" />
      <Connection Source="DoorOpened2" Destination="FB1.DoorOpened2" />
      <Connection Source="FB1.door0" Destination="Open0" />
      <Connection Source="FB1.door1" Destination="Open1" />
      <Connection Source="FB1.door2" Destination="Open2" />
      <Connection Source="FB1.t1_PT" Destination="FB2.DT" dx1="971.5835">
        <AvoidsNodes>false</AvoidsNodes>
      </Connection>
    </DataConnections>
    <Input Name="OnFloor0" x="1100" y="872" Type="Data" />
    <Input Name="OnFloor1" x="1100" y="932" Type="Data" />
    <Input Name="OnFloor2" x="1100" y="992" Type="Data" />
    <Input Name="DoorClosed0" x="1100" y="1412" Type="Data" />
    <Input Name="DoorClosed1" x="1100" y="1472" Type="Data" />
    <Input Name="DoorClosed2" x="1100" y="1532" Type="Data" />
    <Input Name="ButtonAt0" x="1100" y="1052" Type="Data" />
    <Input Name="ButtonAt1" x="1100" y="1112" Type="Data" />
    <Input Name="ButtonAt2" x="1100" y="1172" Type="Data" />
    <Input Name="ButtonFor0" x="1100" y="1232" Type="Data" />
    <Input Name="ButtonFor1" x="1100" y="1292" Type="Data" />
    <Input Name="ButtonFor2" x="1100" y="1352" Type="Data" />
    <Input Name="DoorOpened0" x="1100" y="1592" Type="Data" />
    <Input Name="DoorOpened1" x="1100" y="1652" Type="Data" />
    <Input Name="DoorOpened2" x="1100" y="1712" Type="Data" />
    <Input Name="INIT" x="1120" y="552" Type="Event" />
    <Input Name="REQ" x="1020" y="612" Type="Event" />
    <Output Name="MoveUp" x="2860" y="872" Type="Data" />
    <Output Name="MoveDown" x="2860" y="932" Type="Data" />
    <Output Name="Open0" x="2860" y="992" Type="Data" />
    <Output Name="Open1" x="2860" y="1052" Type="Data" />
    <Output Name="Open2" x="2860" y="1112" Type="Data" />
    <Output Name="INITO" x="2880" y="552" Type="Event" />
    <Output Name="CNF" x="2880" y="612" Type="Event" />
  </SubAppNetwork>
</SubAppType>