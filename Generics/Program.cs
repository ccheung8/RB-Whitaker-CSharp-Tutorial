// using T is pretty universal
// can also use names prefixed with T such as TKey or TValue
// T : IFileParser indicates that T can be any type as long as it implements the
// IFileParser interface from the interfaces section. This is how constraints are added
public class PracticeList<T> where T: IFileParser {
  private T[] _items;

  public PracticeList() {
    _items = new T[0];
  }

  public void Add(T newItem) {
    // Make new array, slightly larger than current one
    T[] newItems = new T[_items.Length + 1];

    // Copy everything over to new array
    Array.Copy(_items, newItems, _items.Length);

    // In last slot, put new number
    newItems[newItems.Length - 1] = newItem;

    // upate the array this object is tracking with new, longer array
    // the old one will be cleaned up by garbage collector
    _items = newItems;
  }

  public T Getitem(int index) {
    return _items[index];
  }
}