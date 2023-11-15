using PatronAdapter;

Motor motor;
int value = 3;
switch(value)
{
    case 1:
        motor = new MotorDisel();
        motor.Arrancar();
        motor.Acelerar();
        motor.Detener();
        motor.CargarConbustible();
        break;
    case 2:
        motor = new MotorNaftero();
        motor.Arrancar();
        motor.Acelerar();
        motor.Detener();
        motor.CargarConbustible();
        break;
    case 3:
        motor = new PatronElectricoAdapter();
        motor.Arrancar();
        motor.Acelerar();
        motor.Detener();
        motor.CargarConbustible();
        break;
    default:
        motor = null;
        break;
}