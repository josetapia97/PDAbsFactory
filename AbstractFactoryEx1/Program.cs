using AbstractFactoryEx1;
using AbstractFactoryEx1.Factories;

//suponiendo que estoy trabajando en windows
IThemeFactory themeFact = new WindowsFactory();

//Ahora podemos pedirle al factory que cree cualquier elemento ya dado.

IButton button = themeFact.CreateButton();
button.render();

IDropDown dropDown = themeFact.CreateDropDown();
dropDown.render();

ITextBox textBox = themeFact.CreateTextBox();
textBox.render();