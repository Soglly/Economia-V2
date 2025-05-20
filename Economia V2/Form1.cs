namespace Economia_V2
{
    public partial class Economia : Form
    {
        string DesExpli = "No se puede resolver un problema de desempleo con una pol�tica contractiva porque, " +
                "en general, una pol�tica fiscal o monetaria contractiva reduce la demanda agregada en la econom�a. " +
                "Esto ocurre, por ejemplo, cuando el gobierno recorta el gasto p�blico o aumenta los impuestos, o " +
                "cuando el banco central reduce la oferta monetaria o aumenta las tasas de inter�s. Estas medidas" +
                " encarecen el cr�dito, reducen el consumo y la inversi�n, lo que provoca una ca�da en la producci�n " +
                "y el empleo.\r\n\r\nCuando la econom�a est� experimentando desempleo, la soluci�n suele ser estimular " +
                "la demanda agregada para reactivar el consumo y la inversi�n, lo cual es contrario a las pol�ticas contractivas." +
                " Por tanto, en un contexto de desempleo, las pol�ticas contractivas solo empeoran la situaci�n, ya que generan " +
                "una mayor contracci�n econ�mica y un aumento del desempleo.";

        string InflaExplica = "No se puede resolver un problema de inflaci�n con una pol�tica expansiva porque " +
                "este tipo de pol�ticas tiende a aumentar la demanda agregada en la econom�a. Una pol�tica fiscal expansiva " +
                "(como aumentar el gasto p�blico o reducir impuestos) o una pol�tica monetaria expansiva (como aumentar la oferta" +
                " monetaria o reducir las tasas de inter�s) estimula el consumo y la inversi�n, lo que puede generar un aumento en" +
                " la demanda de bienes y servicios.\r\n\r\nSi la econom�a ya est� operando cerca de su capacidad m�xima de producci�n " +
                "(pleno empleo), un aumento de la demanda puede generar presiones inflacionarias, ya que la oferta de bienes y servicios " +
                "no puede ajustarse r�pidamente para satisfacer la mayor demanda. Como resultado, los precios tienden a subir, agravando " +
                "la inflaci�n.";

        string FisExpExplica = "En al politica fiscal expansiva no se pueden subir el cosumo y el gasto publico en la demanada agregada, ya que " +
                "para subir el consumo se bajan los impuesstos y si bajan los impuestos baja el gasto publico. De igual manera para subir el " +
                "gastos publico se suben los impuesos y si suben los impuestos baja el consimo";

        string FisContExplica = "No se puede contraer el consumo y el gasto publico a la vez, ya que para bajar el consumo de suben los " +
            "impuestos y esto significa un subida en el gasto publico. De igual forma para poder bajar el gasto publico se deben bajar " +
            "los impuestos y esto crea un mayor consumo";
        public Economia()
        {
            InitializeComponent();
        }
        //Al iniciar el programa

        private void Economia_Load(object sender, EventArgs e)
        {
            pBienvenida.Visible = true;
            pProblema.Visible = false;
            pInfo.Visible = false;

            //Explicacion
            pDesContExpli.Visible = false;
            pInflaExpExpli.Visible = false;
            lExplicacion.Visible = false;
            pExpliAmbosFisExp.Visible = false;
            pExpliAmbosFisCont.Visible = false;


            //Desemplo
            pDes.Visible = false;
            pDesClaPol.Visible = false;
            pDesKeyPol.Visible = false;
            pDesClaPolFis.Visible = false;
            pDesClaPolMon.Visible = false;
            pDesKeyPolFisc.Visible = false;
            pDesKeyPolMon.Visible = false;
            pDesKeyPolFisVar.Visible = false;
            pDesClaPolFisVar.Visible = false;
            pDesKeyPolMonVar.Visible = false;
            pDesClaPolMonVar.Visible = false;
            pDesClaPolFisGas.Visible = false;
            pDesClaPolFisCon.Visible = false;
            pDesClaPolMonInv.Visible = false;
            pDesClaPolMonM.Visible = false;
            pDesClaPolMonAmbos.Visible = false;
            pDesKeyPolFisGas.Visible = false;
            pDesKeyPolFisCon.Visible = false;
            pDesKeyPolMonInv.Visible = false;
            pDesKeyPolMonM.Visible = false;
            pDesKeyPolMonAmbos.Visible = false;


            //Inflacion
            pInfla.Visible = false;
            pInflaClaPol.Visible = false;
            pInflaKeyPol.Visible = false;
            pInflaClaPolFis.Visible = false;
            pInflaClaPolMon.Visible = false;
            pInflaKeyPolFis.Visible = false;
            pInflaKeyPolMon.Visible = false;
            pInflaClaPolFisVar.Visible = false;
            pInflaKeyPolFisVar.Visible = false;
            pInflaKeyPolMonVar.Visible = false;
            pInflaClasicoPolMonVar.Visible = false;
            pInflaClaPolFisGas.Visible = false;
            pInflaClaPolFisCon.Visible = false;
            pInflaClaPolMonInv.Visible = false;
            pInflaClaPolMonM.Visible = false;
            pInflaClaPolMonAmbos.Visible = false;
            pInflaKeyPolFisGas.Visible = false;
            pInflaKeyPolFisCon.Visible = false;
            pInflaKeyPolMonInv.Visible = false;
            pInflaKeyPolMonM.Visible = false;
            pInflaKeyPolMonAmbos.Visible = false;
        }
        //panel info
        private void info_leave(object sender, EventArgs e)
        {
            lInfo.Text = "";
        }
        private void Comenzar_Click(object sender, EventArgs e)
        {
            pProblema.Visible = true;
            pBienvenida.Visible = false;
        }

        //Panel Problema
        private void bDes_Click(object sender, EventArgs e)
        {
            pDes.Visible = true;
            pInfo.Visible = true;
            pProblema.Visible = false;
        }

        private void bInfla_Click(object sender, EventArgs e)
        {
            pProblema.Visible = false;
            pInfo.Visible = true;
            pInfla.Visible = true;
        }
        private void bProblemasAtras_Click(object sender, EventArgs e)
        {
            pProblema.Visible = false;
            pBienvenida.Visible = true;
        }

        //panel Desempleo Modelos
        //Boton Clasico
        private void Clasico_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "El modelo cl�sico sostiene que la econom�a tiende de forma natural al pleno empleo gracias" +
                " a la flexibilidad de precios y salarios. Considera que la oferta crea su propia demanda, por lo que " +
                "no puede existir desempleo involuntario en el largo plazo. Adem�s, afirma que el mercado se autorregula " +
                "sin necesidad de intervenci�n estatal significativa, y que el dinero solo influye en los precios, no en la producci�n real.";
        }

        private void bDesCla_Click(object sender, EventArgs e)
        {
            pDes.Visible = false;
            pDesClaPol.Visible = true;

        }
        //Boton Keynesiano
        private void Keynes_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "El modelo keynesiano plantea que la econom�a puede experimentar desequilibrios prolongados, como el desempleo, " +
                "debido a una demanda agregada insuficiente. A diferencia del modelo cl�sico, defiende la intervenci�n del Estado " +
                "mediante el gasto p�blico y la pol�tica fiscal para estimular la producci�n y el empleo. Los precios y salarios " +
                "no se ajustan r�pidamente, por lo que el mercado no siempre se autorregula eficientemente.";
        }

        private void bDesKey_Click(object sender, EventArgs e)
        {
            pDes.Visible = false;
            pDesKeyPol.Visible = true;

        }

        //Boton Atras
        private void bDesAtras_Click(object sender, EventArgs e)
        {
            pDes.Visible = false;
            pProblema.Visible = true;
            pInfo.Visible = false;
        }

        //Panel Inflacion Modelos
        private void bInflaCla_Click(object sender, EventArgs e)
        {
            pInfla.Visible = false;
            pInflaClaPol.Visible = true;
        }

        private void bInflaKey_Click(object sender, EventArgs e)
        {
            pInfla.Visible = false;
            pInflaKeyPol.Visible = true;
        }
        //Boton Atras

        private void bInflaAtras_Click(object sender, EventArgs e)
        {
            pInfla.Visible = false;
            pProblema.Visible = true;
            pInfo.Visible = false;
        }
        //Panel Desempleo Clasico Politicas
        //Boton Politica Fiscal
        private void ClasicoFiscal_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "Seg�n el modelo cl�sico, la pol�tica fiscal tiene un impacto limitado sobre la producci�n y el empleo," +
                " ya que se parte del supuesto de que la econom�a tiende naturalmente al pleno empleo gracias a la flexibilidad " +
                "de precios, salarios y tasas de inter�s. En este enfoque, el gasto p�blico y los impuestos solo afectan la asignaci�n" +
                " de recursos, pero no alteran el nivel de producci�n real en el largo plazo. Los economistas cl�sicos consideran que " +
                "cualquier aumento del gasto p�blico financiado con deuda desplazar� la inversi�n privada (efecto desplazamiento), " +
                "4debido al aumento en la tasa de inter�s. Por ello, promueven una intervenci�n m�nima del Estado y el equilibrio " +
                "presupuestario como principios fundamentales de pol�tica fiscal.";
        }
        private void bDesClaPolFis_Click(object sender, EventArgs e)
        {
            pDesClaPol.Visible = false;
            pDesClaPolFis.Visible = true;
        }

        //Boton Politica Monetaria
        private void ClasicoMon_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "Seg�n el modelo cl�sico, la pol�tica monetaria no tiene efectos reales sobre la econom�a a largo plazo, " +
                "ya que se considera que los mercados son eficientes y que la oferta y demanda de dinero determinan de manera autom�tica " +
                "el nivel general de precios. En este enfoque, cualquier aumento en la cantidad de dinero solo provocar� un incremento" +
                " proporcional en los precios (teor�a cuantitativa del dinero), sin afectar el producto real ni el empleo, que ya se" +
                " encuentran en su nivel natural. Por ello, los cl�sicos ven la pol�tica monetaria principalmente como un instrumento " +
                "para controlar la inflaci�n, pero no como una herramienta para estimular la actividad econ�mica.";
        }

        private void bDesClaPolMon_Click(object sender, EventArgs e)
        {
            pDesClaPol.Visible = false;
            pDesClaPolMon.Visible = true;

        }

        //Boton atras
        private void bDesClaPolAtras_Click(object sender, EventArgs e)
        {
            pDesClaPol.Visible = false;
            pDes.Visible = true;
        }

        //panel Desempleo Keynes Politicas
        //Boton Politica Fiscal
        private void KeynesFiscal_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "Seg�n el modelo keynesiano, la pol�tica fiscal es una herramienta fundamental para estabilizar la econom�a," +
                " especialmente en per�odos de recesi�n o desempleo elevado. A diferencia del enfoque cl�sico, los keynesianos sostienen" +
                " que los mercados no se ajustan autom�ticamente al pleno empleo y que la demanda agregada puede ser insuficiente. " +
                "Por eso, proponen que el Estado intervenga activamente mediante el aumento del gasto p�blico o la reducci�n de impuestos" +
                " para estimular el consumo y la inversi�n. Esta intervenci�n puede elevar la producci�n y el empleo en el corto plazo," +
                " compensando la falta de demanda del sector privado y contribuyendo a la recuperaci�n econ�mica.";
        }

        private void bDesKeyPolFis_Click(object sender, EventArgs e)
        {
            pDesKeyPol.Visible = false;
            pDesKeyPolFisc.Visible = true;

        }


        //Boton Politica Monetaria
        private void KeynesMon_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "Seg�n el modelo keynesiano, la pol�tica monetaria puede ser �til para estimular la econom�a, pero su efectividad " +
                "depende del contexto. En �pocas de recesi�n o baja confianza, los keynesianos sostienen que reducir las tasas de inter�s" +
                " o aumentar la oferta monetaria puede no ser suficiente para reactivar la inversi�n, ya que las empresas y consumidores" +
                " pueden no responder debido a expectativas negativas (trampa de liquidez). Por ello, aunque reconocen su utilidad, " +
                "consideran que la pol�tica monetaria debe complementarse con una pol�tica fiscal activa para lograr una recuperaci�n " +
                "efectiva. En resumen, la pol�tica monetaria es vista como una herramienta secundaria, especialmente en crisis profundas.";
        }
        private void bDesKeyPolMon_Click(object sender, EventArgs e)
        {
            pDesKeyPol.Visible = false;
            pDesKeyPolMon.Visible = true;
        }

        //Boton atras
        private void bDesKeyPolAtras_Click(object sender, EventArgs e)
        {
            pDesKeyPol.Visible = false;
            pDes.Visible = true;
        }


        //Panel Inflacion Clasico Politicas
        //Boton Politica Fiscal
        private void bInflaClaPolFis_Click(object sender, EventArgs e)
        {
            pInflaClaPolFis.Visible = true;
            pInflaClaPol.Visible = false;
        }
        //Boton Politica Monetaria
        private void bInflaClaPolMon_Click(object sender, EventArgs e)
        {
            pInflaClaPolMon.Visible = true;
            pInflaClaPol.Visible = false;
        }
        //Boton atras
        private void bInflaClaAtras_Click(object sender, EventArgs e)
        {
            pInflaClaPol.Visible = false;
            pInfla.Visible = true;
        }

        //Panel Inflacion Keynes Politicas
        //Boton Politica Fiscal
        private void bInflaKeyPolFis_Click(object sender, EventArgs e)
        {
            pInflaKeyPol.Visible = false;
            pInflaKeyPolFis.Visible = true;
        }
        //Boton Politica Monetaria
        private void bInflaKeyPolMon_Click(object sender, EventArgs e)
        {
            pInflaKeyPol.Visible = false;
            pInflaKeyPolMon.Visible = true;
        }

        //Boton atras
        private void bInflaKeyPolAtras_Click(object sender, EventArgs e)
        {
            pInflaKeyPol.Visible = false;
            pInfla.Visible = true;
        }

        //Panel Desempelo Clasico Politica monetaria
        //Boton Politica Monetaria Expansiva
        private void bDesClaPolMonExp_Click(object sender, EventArgs e)
        {
            pDesClaPolMonVar.Visible = true;
            pDesClaPolMon.Visible = false;
        }
        //Boton Politica Monetaria Contractiva
        private void bDesClaPolMonCont_Click(object sender, EventArgs e)
        {
            pDesContExpli.Visible = true;
            pDesClaPolMon.Visible = false;
            lInfo.Visible = false;
            lExplicacion.Visible = true;
            lExplicacion.Text = DesExpli;
        }

        //Boton atras 
        private void bDesClaPolMonAtras_Click(object sender, EventArgs e)
        {
            pDesClaPolMon.Visible = false;
            pDesClaPol.Visible = true;
        }

        //Panel Desempleo Clasico Politica Fiscal
        //Boton Politica Fiscal Expansiva
        private void bDesClaPolFisExp_Click(object sender, EventArgs e)
        {
            pDesClaPolFis.Visible = false;
            pDesClaPolFisVar.Visible = true;
        }

        //Boton Politica Fiscal Contractiva
        private void bDesClaPolFisCont_Click(object sender, EventArgs e)
        {
            pDesContExpli.Visible = true;
            pDesClaPolFis.Visible = false;
            lInfo.Visible = false;
            lExplicacion.Visible = true;
            lExplicacion.Text = DesExpli;
        }

        //Boton atras
        private void bDesClaPolFisAtras_Click(object sender, EventArgs e)
        {
            pDesClaPolFis.Visible = false;
            pDesClaPol.Visible = true;
        }

        //panel inflacion Keynes politica fiscal
        //Boton Politica Fiscal Expansiva
        private void bInflaKeyPolFisExp_Click(object sender, EventArgs e)
        {
            pInflaExpExpli.Visible = true;
            pInflaKeyPolFis.Visible = false;
            lInfo.Visible = false;
            lExplicacion.Visible = true;
            lExplicacion.Text = InflaExplica;
        }

        //Boton Politica Fiscal Contractiva
        private void bInflaKeyPolFisCont_Click(object sender, EventArgs e)
        {
            pInflaKeyPolFisVar.Visible = true;
            pInflaKeyPolFis.Visible = false;
        }
        //Boton atras
        private void bInflaKeyPolFisAtras_Click(object sender, EventArgs e)
        {
            pInflaKeyPolFis.Visible = false;
            pInflaKeyPol.Visible = true;
        }

        //panel desempleo Keynes Politica Monetaria
        //Boton Politica Monetaria Expansiva
        private void bDesKeyPolMonExp_Click(object sender, EventArgs e)
        {
            pDesKeyPolMon.Visible = false;
            pDesKeyPolMonVar.Visible = true;
        }
        //Boton Politica Monetaria Contractiva
        private void bDesKeyPolMonCont_Click(object sender, EventArgs e)
        {
            pDesContExpli.Visible = true;
            pDesKeyPolMon.Visible = false;
            lInfo.Visible = false;
            lExplicacion.Visible = true;
            lExplicacion.Text = DesExpli;
        }

        //Boton atras
        private void bDesKeyPolMonAtras_Click(object sender, EventArgs e)
        {
            pDesKeyPolMon.Visible = false;
            pDesKeyPol.Visible = true;
        }

        //panel desempleo keynes politica fiscal
        //Boton Politica Fiscal Expansiva
        private void bDesKeyPolFisExp_Click(object sender, EventArgs e)
        {
            pDesKeyPolFisc.Visible = false;
            pDesKeyPolFisVar.Visible = true;
        }
        //Boton Politica Fiscal Contractiva
        private void bDesKeyPolFisCont_Click(object sender, EventArgs e)
        {
            pDesContExpli.Visible = true;
            pDesKeyPolFisc.Visible = false;
            lInfo.Visible = false;
            lExplicacion.Visible = true;
            lExplicacion.Text = DesExpli;
        }
        //Boton atras
        private void bDesKeyPolFisAtras_Click(object sender, EventArgs e)
        {
            pDesKeyPolFisc.Visible = false;
            pDesKeyPol.Visible = true;
        }

        //Panel inflacion keynes Politica Monetaria
        //Boton Politica Monetaria Expansiva
        private void bInflaKeyPolMonExp_Click(object sender, EventArgs e)
        {
            pInflaExpExpli.Visible = true;
            pInflaKeyPolMon.Visible = false;
            lInfo.Visible = false;
            lExplicacion.Visible = true;
            lExplicacion.Text = InflaExplica;
        }
        //Boton Politica Monetaria Contractiva
        private void bInflaKeyPolMonCont_Click(object sender, EventArgs e)
        {
            pInflaKeyPolMon.Visible = false;
            pInflaKeyPolMonVar.Visible = true;
        }
        //Boton atras
        private void bInflaKeyPolMonAtras_Click(object sender, EventArgs e)
        {
            pInflaKeyPolMon.Visible = false;
            pInflaKeyPol.Visible = true;
        }

        //panel Inflacion Clasico Politica Monetaria
        //Boton Politica Monetaria contractiva
        private void bInflaClaPolMonCont_Click(object sender, EventArgs e)
        {
            pInflaClaPolMon.Visible = false;
            pInflaClasicoPolMonVar.Visible = true;
        }
        //Boton Politica Monetaria Expansiva
        private void bInflaClasPolMonExp_Click(object sender, EventArgs e)
        {
            pInflaExpExpli.Visible = true;
            pInflaClaPolMon.Visible = false;
            lInfo.Visible = false;
            lExplicacion.Visible = true;
            lExplicacion.Text = InflaExplica;
        }
        //Boton atras
        private void bInflaClaPolMonAtras_Click(object sender, EventArgs e)
        {
            pInflaClaPolMon.Visible = false;
            pInflaClaPol.Visible = true;
        }

        //Panel Inflacion Clasico Politica Fiscal
        //Boton Politica Fiscal Expansiva
        private void bInflaClaPolFisExp_Click(object sender, EventArgs e)
        {
            pInflaExpExpli.Visible = true;
            pInflaClaPolFis.Visible = false;
            lInfo.Visible = false;
            lExplicacion.Visible = true;
            lExplicacion.Text = InflaExplica;
        }
        //Boton Politica Fiscal Contractiva
        private void bInflaClaPolFisCont_Click(object sender, EventArgs e)
        {
            pInflaClaPolFisVar.Visible = true;
            pInflaClaPolFis.Visible = false;
        }
        //Boton atras
        private void bInflaClaPolFisAtras_Click(object sender, EventArgs e)
        {
            pInflaClaPolFis.Visible = false;
            pInflaClaPol.Visible = true;
        }


        private void ClaPolFisExp_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "En el modelo cl�sico, una pol�tica fiscal expansiva �es decir, un aumento del gasto p�blico o una reducci�n " +
                "7de impuestos� tiene efectos limitados sobre la producci�n y el empleo. Esto se debe a que se parte del supuesto de que " +
                "la econom�a siempre opera cerca del pleno empleo gracias a la flexibilidad de precios, salarios y tasas de inter�s. " +
                "Seg�n este enfoque, un aumento del gasto p�blico financiado con deuda puede generar un efecto desplazamiento " +
                "(crowding out), en el que la mayor demanda de fondos por parte del Estado eleva las tasas de inter�s y " +
                "reduce la inversi�n privada. Por tanto, en lugar de aumentar el producto total, la pol�tica fiscal " +
                "expansiva solo redistribuye recursos entre el sector p�blico y privado, sin mejorar el nivel real de actividad econ�mica.";
        }

        private void ClaPolFisCont_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "En el modelo cl�sico, una pol�tica fiscal contractiva como la reducci�n del gasto p�blico o el aumento de " +
                "impuestos no afecta negativamente al nivel de producci�n ni al empleo en el largo plazo, ya que se asume que la econom�a " +
                "se autorregula y siempre tiende al pleno empleo. Desde esta perspectiva, reducir el d�ficit fiscal mediante una pol�tica" +
                " contractiva puede incluso tener efectos positivos, ya que disminuye la demanda de fondos del Estado, baja las tasas de" +
                " inter�s y estimula la inversi�n privada. Adem�s, al limitar la intervenci�n del gobierno, se favorece una asignaci�n" +
                " m�s eficiente de los recursos. En resumen, para los cl�sicos, la pol�tica fiscal contractiva contribuye a" +
                " la estabilidad macroecon�mica sin sacrificar el crecimiento econ�mico.";
        }

        private void ClaPolMonExp_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "En el modelo cl�sico, una pol�tica monetaria expansiva es decir, un aumento en la oferta monetaria por parte " +
                "del banco central solo tiene efectos en el nivel general de precios, no en la producci�n ni en el empleo. Esto se debe" +
                " a que los cl�sicos asumen que la econom�a est� en pleno empleo y que los mercados se ajustan autom�ticamente. " +
                "Seg�n la teor�a cuantitativa del dinero, si se incrementa la cantidad de dinero en circulaci�n, los precios subir�n" +
                " proporcionalmente, mientras que el producto real permanecer� constante. Por tanto, en el modelo cl�sico," +
                " una pol�tica monetaria expansiva solo genera inflaci�n sin estimular la actividad econ�mica real.";
        }

        private void ClaPolMonCont_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "En el modelo cl�sico, una pol�tica monetaria contractiva como la reducci�n de la oferta monetaria o " +
                "el aumento de las tasas de inter�s tampoco afecta el nivel de producci�n ni el empleo en el largo plazo," +
                " ya que se supone que la econom�a siempre opera en pleno empleo. Seg�n la teor�a cuantitativa del dinero, " +
                "una disminuci�n en la cantidad de dinero solo provoca una reducci�n proporcional en el nivel general de precios, " +
                "mientras que el producto real se mantiene constante. Por tanto, en el enfoque cl�sico, la pol�tica monetaria" +
                " contractiva es �til para controlar la inflaci�n, pero no se considera una herramienta para influir en la actividad " +
                "econ�mica real.";
        }

        private void KeyPolMonExp_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "En el modelo keynesiano, una pol�tica monetaria expansiva como la reducci�n de las tasas de inter�s o el aumento " +
               "de la oferta monetaria busca estimular la demanda agregada incentivando el consumo y, sobre todo, la inversi�n. " +
               "Al bajar las tasas de inter�s, se abarata el cr�dito, lo que puede alentar a las empresas a invertir y a los" +
               " consumidores a gastar m�s. Sin embargo, su efectividad depende del contexto econ�mico: en situaciones normales" +
               " puede impulsar la actividad econ�mica, pero en una recesi�n profunda o en una \"trampa de liquidez\", los agentes " +
               "pueden preferir ahorrar en lugar de gastar o invertir, limitando su impacto. Por eso, los keynesianos consideran que " +
               "la pol�tica monetaria debe complementarse con pol�tica fiscal en estos casos.";
        }

        private void KeyPolMonCont_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "En el modelo keynesiano, una pol�tica monetaria contractiva como la reducci�n de la oferta monetaria " +
                "o el aumento de las tasas de inter�s tiene como objetivo principal frenar la inflaci�n cuando la econom�a " +
                "est� sobrecalentada. Al elevarse las tasas de inter�s, se encarece el cr�dito, lo que desincentiva el " +
                "consumo y la inversi�n, reduciendo as� la demanda agregada. Esto puede ayudar a controlar los aumentos" +
                " excesivos de precios. Sin embargo, los keynesianos advierten que si se aplica en momentos de bajo crecimiento" +
                " o alto desempleo, esta pol�tica puede agravar la recesi�n al debilitar a�n m�s la demanda. Por tanto, " +
                "consideran que su uso debe ser cuidadoso y depender del contexto econ�mico.";
        }

        private void KeyPolFisCont_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "En el modelo keynesiano, una pol�tica fiscal contractiva como la reducci�n del gasto p�blico o el aumento" +
                " de impuestos disminuye la demanda agregada y, por tanto, puede reducir la producci�n y el empleo, especialmente " +
                "en per�odos de desaceleraci�n econ�mica. Los keynesianos advierten que aplicar este tipo de pol�tica en una econom�a " +
                "con desempleo puede empeorar la situaci�n, ya que el menor gasto p�blico y el aumento de la carga tributaria reducen " +
                "el consumo y la inversi�n. Sin embargo, en contextos de crecimiento acelerado con riesgo de inflaci�n, una pol�tica " +
                "fiscal contractiva puede ser �til para estabilizar la econom�a. En general, los keynesianos defienden una pol�tica " +
                "fiscal activa que se adapte al ciclo econ�mico.";
        }

        private void KeyPolFisExp_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "En el modelo keynesiano, la pol�tica fiscal expansiva aumentar el gasto p�blico o reducir los impuestos es una" +
                " herramienta clave para estimular la demanda agregada y reactivar la econom�a en tiempos de recesi�n o desempleo " +
                "elevado. Al incrementar el gasto del Estado o dejar m�s dinero disponible en manos de los consumidores y empresas," +
                " se fomenta el consumo y la inversi�n, lo que a su vez genera mayor producci�n y empleo. Este efecto puede amplificarse" +
                " a trav�s del multiplicador fiscal. A diferencia del modelo cl�sico, los keynesianos creen que el mercado no se ajusta " +
                "autom�ticamente al pleno empleo, por lo que es necesaria la intervenci�n del gobierno para estabilizar la econom�a.";
        }
        //Boton Home para paneles de explicacion
        private void bHome2_Click(object sender, EventArgs e)
        {
            lInfo.Text = "";
            lExplicacion.Text = "";
            lExplicacion.Visible = false;
            lInfo.Visible = true;
            Economia_Load(sender, e);
        }

        //Panel Inflacion Keynes Politica Monetaria Varibles
        //boton Atras
        private void bInflaKeyPolMonVarAtras_Click(object sender, EventArgs e)
        {
            pInflaKeyPolMonVar.Visible = false;
            pInflaKeyPolMon.Visible = true;
        }
        //boton Inversion
        private void bInflaKeyPolMonVarInv_Click(object sender, EventArgs e)
        {
            pInflaKeyPolMonVar.Visible = false;
            pInfo.Visible = false;
            pInflaKeyPolMonInv.Visible = true;
        }
        //boton oferta de dinero
        private void bInflaKeyPolMonVarXn_Click(object sender, EventArgs e)
        {
            pInflaKeyPolMonVar.Visible = false;
            pInfo.Visible = false;
            pInflaKeyPolMonM.Visible = true;
        }
        //boton ambos
        private void bInflaKeyPolMonVarAmbos_Click(object sender, EventArgs e)
        {
            pInflaKeyPolMonVar.Visible = false;
            pInfo.Visible = false;
            pInflaKeyPolMonAmbos.Visible = true;
        }
        //Panel Inflacion Clasico Politica Monetaria Varibles
        //boton Atras
        private void bInflaClasicoPolMonVarAtras_Click(object sender, EventArgs e)
        {
            pInflaClasicoPolMonVar.Visible = false;
            pInflaClaPolMon.Visible = true;
        }
        //boton Inversion
        private void bInflaClasicoPolMonVarInv_Click(object sender, EventArgs e)
        {
            pInflaClasicoPolMonVar.Visible = false;
            pInfo.Visible = false;
            pInflaClaPolMonInv.Visible = true;
        }
        //Boton Ofera de dinero
        private void bInflaClasicoPolMonVarXn_Click(object sender, EventArgs e)
        {
            pInflaClasicoPolMonVar.Visible = false;
            pInfo.Visible = false;
            pInflaClaPolMonM.Visible = true;
        }
        //Boton Ambos
        private void bInflaClasicoPolMonVarAmbos_Click(object sender, EventArgs e)
        {
            pInflaClasicoPolMonVar.Visible = false;
            pInfo.Visible = false;
            pInflaClaPolMonAmbos.Visible = true;
        }

        //Panel Inflacion Keyness Politica Fiscal Varibles
        //Boton atras
        private void bInlfaKeyPolFisVarAtras_Click(object sender, EventArgs e)
        {
            pInflaKeyPolFisVar.Visible = false;
            pInflaKeyPolFis.Visible = true;
        }
        //boton Consumo
        private void bInlfaKeyPolFisVarCon_Click(object sender, EventArgs e)
        {
            pInflaKeyPolFisVar.Visible = false;
            pInfo.Visible = false;
            pInflaKeyPolFisCon.Visible = true;
        }
        //boton Gasto

        private void bInlfaKeyPolFisVarGas_Click(object sender, EventArgs e)
        {
            pInflaKeyPolFisVar.Visible = false;
            pInfo.Visible = false;
            pInflaKeyPolFisGas.Visible = true;
        }
        //boton ambos
        private void bInlfaKeyPolFisVarAmbos_Click(object sender, EventArgs e)
        {
            pInflaKeyPolFisVar.Visible = false;
            pExpliAmbosFisCont.Visible = true;
            lInfo.Text = FisContExplica;
        }

        //Panel Inflacion Clasico Politica Fiscal Varibles
        //Boton atras
        private void bInflaClaPolFisVarAtras_Click(object sender, EventArgs e)
        {
            pInflaClaPolFisVar.Visible = false;
            pInflaClaPolFis.Visible = true;
        }
        //boton Consumo
        private void bInflaClaPolFisVarCon_Click(object sender, EventArgs e)
        {
            pInflaClaPolFisVar.Visible = false;
            pInfo.Visible = false;
            pInflaClaPolFisCon.Visible = true;
        }
        //boton Gasto
        private void bInflaClaPolFisVarGas_Click(object sender, EventArgs e)
        {
            pInflaClaPolFisVar.Visible = false;
            pInfo.Visible = false;
            pInflaClaPolFisGas.Visible = true;
        }
        //boton ambos
        private void bInflaClaPolFisVarAmbos_Click(object sender, EventArgs e)
        {
            pInflaClaPolFisVar.Visible = false;
            pExpliAmbosFisCont.Visible = true;
            lInfo.Text = FisContExplica;
        }

        //Panel Desempleo Keynes Politica monetaria Varibles
        //boton atras
        private void bDesKeyPolMonVarAtras_Click(object sender, EventArgs e)
        {
            pDesKeyPolMonVar.Visible = false;
            pDesKeyPolMon.Visible = true;
        }
        private void bDesKeyPolMonVarInv_Click(object sender, EventArgs e)
        {
            pDesKeyPolMonVar.Visible = false;
            pInfo.Visible = false;
            pDesKeyPolMonInv.Visible = true;
        }
        private void bDesKeyPolMonVarXn_Click(object sender, EventArgs e)
        {
            pDesKeyPolMonVar.Visible = false;
            pInfo.Visible = false;
            pDesKeyPolMonM.Visible = true;
        }
        private void bDesKeyPolMonVarAmbos_Click(object sender, EventArgs e)
        {
            pDesKeyPolMonVar.Visible = false;
            pInfo.Visible = false;
            pDesKeyPolMonAmbos.Visible = true;
        }

        //Panel Desempleo Clasico Politica monetaria Varibles
        //boton atras
        private void bDesClaPolMonVarAtras_Click(object sender, EventArgs e)
        {
            pDesClaPolMonVar.Visible = false;
            pDesClaPolMon.Visible = true;
        }
        //Boton Inversion
        private void bDesClaPolMonVarInv_Click(object sender, EventArgs e)
        {
            pDesClaPolMonVar.Visible = false;
            pInfo.Visible = false;
            pDesClaPolMonInv.Visible = true;
        }
        //Boton oferta de dinero
        private void bDesClaPolMonVarM_Click(object sender, EventArgs e)
        {
            pDesClaPolMonVar.Visible = false;
            pInfo.Visible = false;
            pDesClaPolMonM.Visible = true;
        }
        private void bDesClaPolMonVarAmbos_Click(object sender, EventArgs e)
        {
            pDesClaPolMonVar.Visible = false;
            pInfo.Visible = false;
            pDesClaPolMonAmbos.Visible = true;
        }
        //Panel Desempleo Keynes Politica Fiscal Varibles
        //boton atras
        private void bDesKeyPolFisVarAtras_Click(object sender, EventArgs e)
        {
            pDesKeyPolFisVar.Visible = false;
            pDesKeyPolFisc.Visible = true;
        }
        //boton consumo 
        private void bDesKeyPolFisVarCon_Click(object sender, EventArgs e)
        {
            pDesKeyPolFisVar.Visible = false;
            pInfo.Visible = false;
            pDesKeyPolFisCon.Visible = true;
        }
        //boton gasto

        private void bDesKeyPolFisVarGas_Click(object sender, EventArgs e)
        {
            pDesKeyPolFisVar.Visible = false;
            pInfo.Visible = false;
            pDesKeyPolFisGas.Visible = true;
        }
        //boton ambos

        private void bDesKeyPolFisVarAmbos_Click(object sender, EventArgs e)
        {
            pDesKeyPolFisVar.Visible = false;
            pExpliAmbosFisExp.Visible = true;
            lInfo.Text = FisExpExplica;
        }

        //Panel Desempleo Clasico Politica Fiscal Varibles
        //Boton atras
        private void bDesClaPolFisVarAtras_Click(object sender, EventArgs e)
        {
            pDesClaPolFisVar.Visible = false;
            pDesClaPolFis.Visible = true;
        }
        //Boton Gasto
        private void bDesClaPolFisVarGas_Click(object sender, EventArgs e)
        {
            pDesClaPolFisVar.Visible = false;
            pInfo.Visible = false;
            pDesClaPolFisGas.Visible = true;
        }
        //boton consumo
        private void bDesClaPolFisVarCon_Click(object sender, EventArgs e)
        {
            pDesClaPolFisVar.Visible = false;
            pInfo.Visible = false;
            pDesClaPolFisCon.Visible = true;
        }
        //boton ambos

        private void bDesClaPolFisVarAmbos_Click(object sender, EventArgs e)
        {
            pDesClaPolFisVar.Visible = false;
            pExpliAmbosFisExp.Visible = true;
            lInfo.Text = FisExpExplica;
        }


    }

}

