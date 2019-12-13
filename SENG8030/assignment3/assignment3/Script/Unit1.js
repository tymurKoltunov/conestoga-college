function Test4()
{
  var Var1;
  var Var2;
  Var1 = 0;
  //Runs the "ProSumV1" tested application.
  TestedApps.ProSumV1.Run();
  //Checks whether the 'wText' property of the Aliases.ProSumV1.frmProSum.Frame1.txtNumOne object equals ''.
  aqObject.CheckProperty(Aliases.ProSumV1.frmProSum.Frame1.txtNumOne, "wText", cmpEqual, "");
  Var1 = 0;
  //Sets the 'vsNumOneScroll' scrollbar control to position 16136.
  Aliases.ProSumV1.frmProSum.Frame1.vsNumOneScroll.wPosition = 16136;
  Var2 = aqConvert.StrToInt(Aliases.ProSumV1.frmProSum.Frame1.txtNumOne);
  if(Var2 == Var1 + 1);
  //Checks whether the 'wText' property of the Aliases.ProSumV1.frmProSum.Frame1.txtNumOne object equals '1'.
  aqObject.CheckProperty(Aliases.ProSumV1.frmProSum.Frame1.txtNumOne, "wText", cmpEqual, "1");
  //Sets the 'vsNumOneScroll' scrollbar control to position 15971.
  Aliases.ProSumV1.frmProSum.Frame1.vsNumOneScroll.wPosition = 15971;
  //Checks whether the 'wText' property of the Aliases.ProSumV1.frmProSum.Frame1.txtNumOne object equals '2'.
  aqObject.CheckProperty(Aliases.ProSumV1.frmProSum.Frame1.txtNumOne, "wText", cmpEqual, "2");
  //Sets the 'vsNumOneScroll' scrollbar control to position 16136.
  Aliases.ProSumV1.frmProSum.Frame1.vsNumOneScroll.wPosition = 16136;
  //Checks whether the 'wText' property of the Aliases.ProSumV1.frmProSum.Frame1.txtNumOne object equals '1'.
  aqObject.CheckProperty(Aliases.ProSumV1.frmProSum.Frame1.txtNumOne, "wText", cmpEqual, "1");
  //Clicks the 'cmdExit' button.
  Aliases.ProSumV1.frmProSum.cmdExit.ClickButton();
}