

namespace Polimorfismo
{
    public class PagamentoPIX : Pagamento
    {

        public float ValorCompra;
        
        public override float CalcularTotal()
        {
            float ValorDesconto  = ValorCompra / 100 * 5;
            return ValorCompra = ValorCompra - ValorDesconto;
        }
        
    }
}