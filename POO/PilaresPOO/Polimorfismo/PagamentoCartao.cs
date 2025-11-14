

namespace Polimorfismo
{
    public class PagamentoCartao : Pagamento
    {

        public float ValorCompra;
        private float Acrescimo = 5.38f;


        public override float CalcularTotal()
        {
            float ValorAcrescimo  = ValorCompra / 100 * Acrescimo;

                    return ValorCompra = ValorCompra + ValorAcrescimo;
        }
    }
}