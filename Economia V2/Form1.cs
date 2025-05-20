namespace Economia_V2
{
    public partial class Economia : Form
    {
        string DesExpli = "No se puede resolver un problema de desempleo con una política contractiva porque, " +
                "en general, una política fiscal o monetaria contractiva reduce la demanda agregada en la economía. " +
                "Esto ocurre, por ejemplo, cuando el gobierno recorta el gasto público o aumenta los impuestos, o " +
                "cuando el banco central reduce la oferta monetaria o aumenta las tasas de interés. Estas medidas" +
                " encarecen el crédito, reducen el consumo y la inversión, lo que provoca una caída en la producción " +
                "y el empleo.\r\n\r\nCuando la economía está experimentando desempleo, la solución suele ser estimular " +
                "la demanda agregada para reactivar el consumo y la inversión, lo cual es contrario a las políticas contractivas." +
                " Por tanto, en un contexto de desempleo, las políticas contractivas solo empeoran la situación, ya que generan " +
                "una mayor contracción económica y un aumento del desempleo.";

        string InflaExplica = "No se puede resolver un problema de inflación con una política expansiva porque " +
                "este tipo de políticas tiende a aumentar la demanda agregada en la economía. Una política fiscal expansiva " +
                "(como aumentar el gasto público o reducir impuestos) o una política monetaria expansiva (como aumentar la oferta" +
                " monetaria o reducir las tasas de interés) estimula el consumo y la inversión, lo que puede generar un aumento en" +
                " la demanda de bienes y servicios.\r\n\r\nSi la economía ya está operando cerca de su capacidad máxima de producción " +
                "(pleno empleo), un aumento de la demanda puede generar presiones inflacionarias, ya que la oferta de bienes y servicios " +
                "no puede ajustarse rápidamente para satisfacer la mayor demanda. Como resultado, los precios tienden a subir, agravando " +
                "la inflación.";

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
            lInfo.Text = "El modelo clásico sostiene que la economía tiende de forma natural al pleno empleo gracias" +
                " a la flexibilidad de precios y salarios. Considera que la oferta crea su propia demanda, por lo que " +
                "no puede existir desempleo involuntario en el largo plazo. Además, afirma que el mercado se autorregula " +
                "sin necesidad de intervención estatal significativa, y que el dinero solo influye en los precios, no en la producción real.";
        }

        private void bDesCla_Click(object sender, EventArgs e)
        {
            pDes.Visible = false;
            pDesClaPol.Visible = true;

        }
        //Boton Keynesiano
        private void Keynes_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "El modelo keynesiano plantea que la economía puede experimentar desequilibrios prolongados, como el desempleo, " +
                "debido a una demanda agregada insuficiente. A diferencia del modelo clásico, defiende la intervención del Estado " +
                "mediante el gasto público y la política fiscal para estimular la producción y el empleo. Los precios y salarios " +
                "no se ajustan rápidamente, por lo que el mercado no siempre se autorregula eficientemente.";
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
            lInfo.Text = "Según el modelo clásico, la política fiscal tiene un impacto limitado sobre la producción y el empleo," +
                " ya que se parte del supuesto de que la economía tiende naturalmente al pleno empleo gracias a la flexibilidad " +
                "de precios, salarios y tasas de interés. En este enfoque, el gasto público y los impuestos solo afectan la asignación" +
                " de recursos, pero no alteran el nivel de producción real en el largo plazo. Los economistas clásicos consideran que " +
                "cualquier aumento del gasto público financiado con deuda desplazará la inversión privada (efecto desplazamiento), " +
                "4debido al aumento en la tasa de interés. Por ello, promueven una intervención mínima del Estado y el equilibrio " +
                "presupuestario como principios fundamentales de política fiscal.";
        }
        private void bDesClaPolFis_Click(object sender, EventArgs e)
        {
            pDesClaPol.Visible = false;
            pDesClaPolFis.Visible = true;
        }

        //Boton Politica Monetaria
        private void ClasicoMon_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "Según el modelo clásico, la política monetaria no tiene efectos reales sobre la economía a largo plazo, " +
                "ya que se considera que los mercados son eficientes y que la oferta y demanda de dinero determinan de manera automática " +
                "el nivel general de precios. En este enfoque, cualquier aumento en la cantidad de dinero solo provocará un incremento" +
                " proporcional en los precios (teoría cuantitativa del dinero), sin afectar el producto real ni el empleo, que ya se" +
                " encuentran en su nivel natural. Por ello, los clásicos ven la política monetaria principalmente como un instrumento " +
                "para controlar la inflación, pero no como una herramienta para estimular la actividad económica.";
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
            lInfo.Text = "Según el modelo keynesiano, la política fiscal es una herramienta fundamental para estabilizar la economía," +
                " especialmente en períodos de recesión o desempleo elevado. A diferencia del enfoque clásico, los keynesianos sostienen" +
                " que los mercados no se ajustan automáticamente al pleno empleo y que la demanda agregada puede ser insuficiente. " +
                "Por eso, proponen que el Estado intervenga activamente mediante el aumento del gasto público o la reducción de impuestos" +
                " para estimular el consumo y la inversión. Esta intervención puede elevar la producción y el empleo en el corto plazo," +
                " compensando la falta de demanda del sector privado y contribuyendo a la recuperación económica.";
        }

        private void bDesKeyPolFis_Click(object sender, EventArgs e)
        {
            pDesKeyPol.Visible = false;
            pDesKeyPolFisc.Visible = true;

        }


        //Boton Politica Monetaria
        private void KeynesMon_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "Según el modelo keynesiano, la política monetaria puede ser útil para estimular la economía, pero su efectividad " +
                "depende del contexto. En épocas de recesión o baja confianza, los keynesianos sostienen que reducir las tasas de interés" +
                " o aumentar la oferta monetaria puede no ser suficiente para reactivar la inversión, ya que las empresas y consumidores" +
                " pueden no responder debido a expectativas negativas (trampa de liquidez). Por ello, aunque reconocen su utilidad, " +
                "consideran que la política monetaria debe complementarse con una política fiscal activa para lograr una recuperación " +
                "efectiva. En resumen, la política monetaria es vista como una herramienta secundaria, especialmente en crisis profundas.";
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
            lInfo.Text = "En el modelo clásico, una política fiscal expansiva —es decir, un aumento del gasto público o una reducción " +
                "7de impuestos— tiene efectos limitados sobre la producción y el empleo. Esto se debe a que se parte del supuesto de que " +
                "la economía siempre opera cerca del pleno empleo gracias a la flexibilidad de precios, salarios y tasas de interés. " +
                "Según este enfoque, un aumento del gasto público financiado con deuda puede generar un efecto desplazamiento " +
                "(crowding out), en el que la mayor demanda de fondos por parte del Estado eleva las tasas de interés y " +
                "reduce la inversión privada. Por tanto, en lugar de aumentar el producto total, la política fiscal " +
                "expansiva solo redistribuye recursos entre el sector público y privado, sin mejorar el nivel real de actividad económica.";
        }

        private void ClaPolFisCont_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "En el modelo clásico, una política fiscal contractiva como la reducción del gasto público o el aumento de " +
                "impuestos no afecta negativamente al nivel de producción ni al empleo en el largo plazo, ya que se asume que la economía " +
                "se autorregula y siempre tiende al pleno empleo. Desde esta perspectiva, reducir el déficit fiscal mediante una política" +
                " contractiva puede incluso tener efectos positivos, ya que disminuye la demanda de fondos del Estado, baja las tasas de" +
                " interés y estimula la inversión privada. Además, al limitar la intervención del gobierno, se favorece una asignación" +
                " más eficiente de los recursos. En resumen, para los clásicos, la política fiscal contractiva contribuye a" +
                " la estabilidad macroeconómica sin sacrificar el crecimiento económico.";
        }

        private void ClaPolMonExp_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "En el modelo clásico, una política monetaria expansiva es decir, un aumento en la oferta monetaria por parte " +
                "del banco central solo tiene efectos en el nivel general de precios, no en la producción ni en el empleo. Esto se debe" +
                " a que los clásicos asumen que la economía está en pleno empleo y que los mercados se ajustan automáticamente. " +
                "Según la teoría cuantitativa del dinero, si se incrementa la cantidad de dinero en circulación, los precios subirán" +
                " proporcionalmente, mientras que el producto real permanecerá constante. Por tanto, en el modelo clásico," +
                " una política monetaria expansiva solo genera inflación sin estimular la actividad económica real.";
        }

        private void ClaPolMonCont_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "En el modelo clásico, una política monetaria contractiva como la reducción de la oferta monetaria o " +
                "el aumento de las tasas de interés tampoco afecta el nivel de producción ni el empleo en el largo plazo," +
                " ya que se supone que la economía siempre opera en pleno empleo. Según la teoría cuantitativa del dinero, " +
                "una disminución en la cantidad de dinero solo provoca una reducción proporcional en el nivel general de precios, " +
                "mientras que el producto real se mantiene constante. Por tanto, en el enfoque clásico, la política monetaria" +
                " contractiva es útil para controlar la inflación, pero no se considera una herramienta para influir en la actividad " +
                "económica real.";
        }

        private void KeyPolMonExp_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "En el modelo keynesiano, una política monetaria expansiva como la reducción de las tasas de interés o el aumento " +
               "de la oferta monetaria busca estimular la demanda agregada incentivando el consumo y, sobre todo, la inversión. " +
               "Al bajar las tasas de interés, se abarata el crédito, lo que puede alentar a las empresas a invertir y a los" +
               " consumidores a gastar más. Sin embargo, su efectividad depende del contexto económico: en situaciones normales" +
               " puede impulsar la actividad económica, pero en una recesión profunda o en una \"trampa de liquidez\", los agentes " +
               "pueden preferir ahorrar en lugar de gastar o invertir, limitando su impacto. Por eso, los keynesianos consideran que " +
               "la política monetaria debe complementarse con política fiscal en estos casos.";
        }

        private void KeyPolMonCont_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "En el modelo keynesiano, una política monetaria contractiva como la reducción de la oferta monetaria " +
                "o el aumento de las tasas de interés tiene como objetivo principal frenar la inflación cuando la economía " +
                "está sobrecalentada. Al elevarse las tasas de interés, se encarece el crédito, lo que desincentiva el " +
                "consumo y la inversión, reduciendo así la demanda agregada. Esto puede ayudar a controlar los aumentos" +
                " excesivos de precios. Sin embargo, los keynesianos advierten que si se aplica en momentos de bajo crecimiento" +
                " o alto desempleo, esta política puede agravar la recesión al debilitar aún más la demanda. Por tanto, " +
                "consideran que su uso debe ser cuidadoso y depender del contexto económico.";
        }

        private void KeyPolFisCont_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "En el modelo keynesiano, una política fiscal contractiva como la reducción del gasto público o el aumento" +
                " de impuestos disminuye la demanda agregada y, por tanto, puede reducir la producción y el empleo, especialmente " +
                "en períodos de desaceleración económica. Los keynesianos advierten que aplicar este tipo de política en una economía " +
                "con desempleo puede empeorar la situación, ya que el menor gasto público y el aumento de la carga tributaria reducen " +
                "el consumo y la inversión. Sin embargo, en contextos de crecimiento acelerado con riesgo de inflación, una política " +
                "fiscal contractiva puede ser útil para estabilizar la economía. En general, los keynesianos defienden una política " +
                "fiscal activa que se adapte al ciclo económico.";
        }

        private void KeyPolFisExp_MouseHover(object sender, EventArgs e)
        {
            lInfo.Text = "En el modelo keynesiano, la política fiscal expansiva aumentar el gasto público o reducir los impuestos es una" +
                " herramienta clave para estimular la demanda agregada y reactivar la economía en tiempos de recesión o desempleo " +
                "elevado. Al incrementar el gasto del Estado o dejar más dinero disponible en manos de los consumidores y empresas," +
                " se fomenta el consumo y la inversión, lo que a su vez genera mayor producción y empleo. Este efecto puede amplificarse" +
                " a través del multiplicador fiscal. A diferencia del modelo clásico, los keynesianos creen que el mercado no se ajusta " +
                "automáticamente al pleno empleo, por lo que es necesaria la intervención del gobierno para estabilizar la economía.";
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

