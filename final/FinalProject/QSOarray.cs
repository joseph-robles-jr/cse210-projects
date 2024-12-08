public class QSOarray
{
    //make a list to hold the QSO types
    List<object> _qsoLists = new List<object>();

    

// This function creates a new QSO object of a specified type and adds it to a list. It was created by AI but I now understand most of the code.
private void createNewQSO<T>() where T : new() // The function is generic, allowing any type T that has a parameterless constructor.
    {
        // Create a new instance of the specified type T.
        T qso = new T();

        // Add the new instance to the _qsoLists list.
        _qsoLists.Add(qso);

        // Cast the new instance to dynamic to allow calling its methods without knowing the exact type at compile time.
        dynamic dynamicQSO = qso; //This allows us to store multiple kinds of objects in a list

        // Call the newQso method on the new instance.
        dynamicQSO.newQso();
    }

public void newUsbQso()
    {
        createNewQSO<USB>();    
    }

public void newLsbQso()
    {
        createNewQSO<LSB>();    
    }

public void newCwQso()
    {
        createNewQSO<Cw>();    
    }

public void newAmQso()
    {
        createNewQSO<AM>();    
    }

public void newFmQso()
    {
        createNewQSO<FM>();    
    }

}