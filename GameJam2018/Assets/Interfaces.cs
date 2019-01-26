using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface Interactable
{
	void isUsed();
}

public interface Ipickable<T>{
	void pickup (T theGameobject);
}