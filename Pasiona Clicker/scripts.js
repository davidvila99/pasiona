let Pasiona = {
  //CodeLines
  TotalCodeLines: 0,
  CodeLines: 0,
  CodeLinesPerSecond: 0,

  //Money
  Money: 1000000,

  //Minions
  MinionsCodeLinesPerSecond: 0.10,
  Minions: 0,
  MinionPrice: 10,
  MaxMinionCapacity: 50,

  //Office
  Office: 1,
  OfficePrice: 1000,

  //Hard Drive
  HardDrive: 1,
  MaxCodeLinesCapacity: 10000,
  HardDrivePrice: 100,

  //Formador
  Formador: 0,
  FormadorPrice: 1000,
  MaxFormadores: 1,

  //CoffeMachine
  CoffeMachine: 0,
  CoffeMachinePrice: 500,
  MaxCoffeMachines: 1,

  //Incentives
  Incentives: 0,
  IncentivePrice: 200,

  //SCRUMB
  SCRUMB: 0,
  SCRUMBPrice: 10000,

  //Amazon CTO
  AmazonCTO: 0,
  AmazonCTOPrice: 100000,
}

init();

function init(){
  if(localStorage.hasOwnProperty('SaveGame')){
    Pasiona = JSON.parse(localStorage.getItem('SaveGame'))
  }
}

setTimeout(UpdateView, 1)

function clickBtn() {
  if ((Pasiona.TotalCodeLines + 1) < Pasiona.MaxCodeLinesCapacity)
  {
    Pasiona.CodeLines++;
    Pasiona.TotalCodeLines++;
    UpdateView();
  }
}

function Exchange(){
  Pasiona.Money += Pasiona.CodeLines * 0.10;
  Pasiona.CodeLines = 0;
  UpdateView();
}

function MinionBtn(){
  if (Pasiona.Money >= Pasiona.MinionPrice && Pasiona.Minions < Pasiona.MaxMinionCapacity ){
    Pasiona.Money -= Pasiona.MinionPrice;
    Pasiona.Minions++;
    UpdateView();
  }
}

function OfficeBtn(){
  if (Pasiona.Money >= Pasiona.OfficePrice){
    Pasiona.Money -= Pasiona.OfficePrice;
    Pasiona.Office++;
    Pasiona.MaxMinionCapacity += 50;
    UpdateView();
  }
}

function HardDriveBtn(){
  if (Pasiona.Money >= Pasiona.HardDrivePrice){
    Pasiona.Money -= Pasiona.HardDrivePrice;
    Pasiona.HardDrive++;
    Pasiona.MaxCodeLinesCapacity += 10000;
    UpdateView();
  }
}

function FormadorBtn(){
  if (Pasiona.Money >= Pasiona.FormadorPrice && Pasiona.Formador < Pasiona.MaxFormadores){
    Pasiona.Money -= Pasiona.FormadorPrice;
    Pasiona.Formador++;
    Pasiona.MinionsCodeLinesPerSecond = (Pasiona.MinionsCodeLinesPerSecond * 10);
    UpdateView();
  }
}

function CoffeMachineBtn(){
  if (Pasiona.Money >= Pasiona.CoffeMachinePrice && Pasiona.CoffeMachine < Pasiona.MaxCoffeMachines){
    Pasiona.Money -= Pasiona.CoffeMachinePrice;
    Pasiona.CoffeMachine++;
    Pasiona.MinionsCodeLinesPerSecond = (Pasiona.MinionsCodeLinesPerSecond * 2);
    UpdateView();
  }
}

function IncentiveBtn(){
  if (Pasiona.Money >= Pasiona.IncentivePrice && Pasiona.Incentives < Pasiona.MaxMinionCapacity){
    Pasiona.Money -= Pasiona.IncentivePrice;
    Pasiona.Incentives++;
    Pasiona.MinionsCodeLinesPerSecond = (Pasiona.MinionsCodeLinesPerSecond * 2);
    Pasiona.IncentivePrice = Pasiona.IncentivePrice * 1.2;
    UpdateView();
  }
}

function SCRUMBtn(){
  if (Pasiona.Money >= Pasiona.SCRUMBPrice && Pasiona.Minions >= 500){
    Pasiona.Money -= Pasiona.SCRUMBPrice;
    Pasiona.SCRUMB++;
    Pasiona.MinionsCodeLinesPerSecond = (Pasiona.MinionsCodeLinesPerSecond * 4);
    UpdateView();
  }
}

function AmazonCTOBtn(){
  if (Pasiona.Money >= Pasiona.AmazonCTOPrice && Pasiona.Minions >= 500){
    Pasiona.Money -= Pasiona.AmazonCTOPrice;
    Pasiona.AmazonCTO++;
    Pasiona.MinionsCodeLinesPerSecond = (Pasiona.MinionsCodeLinesPerSecond * 50);
    UpdateView();
  }
}

setInterval(lines, 1000);

function lines(){
  if (Pasiona.TotalCodeLines < Pasiona.MaxCodeLinesCapacity){
    Pasiona.CodeLines+=Pasiona.Minions*Pasiona.MinionsCodeLinesPerSecond;
    Pasiona.TotalCodeLines+=Pasiona.Minions*Pasiona.MinionsCodeLinesPerSecond;
  }

  if (Pasiona.TotalCodeLines < Pasiona.MaxCodeLinesCapacity){
    UpdateView();
  }
  else {
    Pasiona.TotalCodeLines = Pasiona.MaxCodeLinesCapacity;
    UpdateView();
  }
}

function UpdateView(){
  localStorage.setItem('datos', JSON.stringify(Pasiona));
  document.getElementsByTagName("h3")[0].firstChild.data = "Code Lines: " + (Pasiona.CodeLines + Pasiona.CodeLinesPerSecond).toFixed(1);
  document.getElementsByTagName("h3")[1].firstChild.data = "Total Code Lines: " +(Pasiona.TotalCodeLines + Pasiona.CodeLinesPerSecond).toFixed(1) + " / " + Pasiona.MaxCodeLinesCapacity;
  document.getElementsByTagName("h2")[1].firstChild.data = Pasiona.Minions + " / " + Pasiona.MaxMinionCapacity;
  document.getElementsByTagName("h2")[3].firstChild.data = Pasiona.Office ;
  document.getElementsByTagName("h2")[5].firstChild.data = Pasiona.HardDrive;
  document.getElementById("Formador").innerHTML = Pasiona.Formador + " / " + Pasiona.MaxFormadores; 
  document.getElementById("CoffeMachine").innerHTML = Pasiona.CoffeMachine + " / " + Pasiona.MaxCoffeMachines; 
  document.getElementById("MinionProduction").innerHTML = "Minion / Price: 10$ / Production: " + Pasiona.MinionsCodeLinesPerSecond + " CodeLines/s"; 
  document.getElementById("Incentive").innerHTML = Pasiona.Incentives;
  document.getElementById("IncentiveInfo").innerHTML = "Incentive / Price: " + Pasiona.IncentivePrice + "$/Minion / MinionProduction x2";
  document.getElementById("SCRUMB").innerHTML = Pasiona.SCRUMB; 
  document.getElementById("Amazon").innerHTML = Pasiona.AmazonCTO; 
  document.getElementsByTagName("h3")[2].firstChild.data = "Money: " + Pasiona.Money.toFixed(2) + "$";
  localStorage.setItem('SaveGame',JSON.stringify(Pasiona));
}
