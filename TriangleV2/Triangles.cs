namespace TriangleV2;

public class Triangles
{
    private double _a;
    private double _b;
    private double _c;
    private double _alfa;
    private double _beta;
    private double _gamma;

  
    public Triangles(double a, double b, double c)
    {
        _a = a;
        _b = a;
        _c = c;
        if (a == b && b == c && a == c)
        {
            _alfa = 60;
            _beta = 60;
            _gamma = 60;
        }
        else
        { 
            _alfa = (180 / Math.PI) * Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c)); 
            _beta = (180 / Math.PI) * Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c)); 
            _gamma = 180 - _alfa - _beta;    
        }
    }

    public double A
    {
        get { return _a; }
    }
    
    public double B
    {
        get { return _b; }
    }
    
    public double C
    {
        get { return _c; }
    }
    
    public double Alfa
    {
        get { return _alfa; }
    }
    
    public double Beta
    {
        get { return _beta; }
    }
    
    public double Gamma
    {
        get { return _gamma; }
    }
    
    public double GetPerimeter
    {
        get
        {
            return _a+_b+_c;
        }
    }
    public double s
    { 
        get
        {
            return GetPerimeter / 2;
        }
    }
    public double GetArea
    {
        get
        {
            return Math.Sqrt(s*(s-_a)*(s-_b)*(s-_c));
        } 
    }
    public bool GetConstructability
    {
        get
        { 
            if (_a + _b > _c && _b + _c > _a && _c + _a > _b) 
            { 
                return true;
            }
            else
            { 
                return false;
            } 
        } 
    }
    public bool GetEquilateral
    {
        get
        {
            if (_a.Equals(_b) && _a.Equals(_c) && _b.Equals(_c)) 
            { 
                return true;
            }
            else
            { 
                return false;
            } 
        }
    }
    public void Resizer(double nasobek)
    {
        _a = _a * nasobek;
        _b = _b * nasobek;
        _c = _c * nasobek;
        if (_a == _b && _b == _c && _a == _c)
        {
            _alfa = 60;
            _beta = 60;
            _gamma = 60;
        }
        else
        { 
            _alfa = (180 / Math.PI) * Math.Acos((Math.Pow(_b, 2) + Math.Pow(_c, 2) - Math.Pow(_a, 2)) / (2 * _b * _c)); 
            _beta = (180 / Math.PI) * Math.Acos((Math.Pow(_a, 2) + Math.Pow(_c, 2) - Math.Pow(_b, 2)) / (2 * _a * _c)); 
            _gamma = 180 - _alfa - _beta;    
        }
    }
    public void Changer(double newA, double newB, double newC)
    {
        if (newA + newB > newC && newB + newC > newA && newC + newA > newB)
        {
            _a = newA;
            _b = newB;
            _c = newC;
            if (_a == _b && _b == _c && _a == _c)
            {
                _alfa = 60;
                _beta = 60;
                _gamma = 60;
            }
            else
            { 
                _alfa = (180 / Math.PI) * Math.Acos((Math.Pow(_b, 2) + Math.Pow(_c, 2) - Math.Pow(_a, 2)) / (2 * _b * _c)); 
                _beta = (180 / Math.PI) * Math.Acos((Math.Pow(_a, 2) + Math.Pow(_c, 2) - Math.Pow(_b, 2)) / (2 * _a * _c)); 
                _gamma = 180 - _alfa - _beta;    
            }
        }
        else
        {
            Console.WriteLine("Trojuhelník nelze sestrojit");
        }
    }
}


