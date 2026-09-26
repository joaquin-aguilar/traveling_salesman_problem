namespace traveling_salesman_problem.Models;

internal class ProblemaTSP
{
    private readonly GrafoPonderado _grafoPonderado;
    public int VericeInicial {get;}
    public int NumeroVertices {get;}

    public ProblemaTSP(GrafoPonderado grafoPonderado, int vericeInicial)
    {
        if(grafoPonderado == null)
            throw new ArgumentNullException("El grafo no puede ser nulo.");

        if(vericeInicial < 0 || vericeInicial >= grafoPonderado.NumeroVertices)
            throw new ArgumentOutOfRangeException("El grafo no contiene un vertice con este indice.");

        _grafoPonderado = grafoPonderado;
        VericeInicial = vericeInicial;
        NumeroVertices = grafoPonderado.NumeroVertices;
    }
}