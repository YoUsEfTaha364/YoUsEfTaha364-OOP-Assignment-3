
  
   the same between 

   they have almost the same methods and they are 2 classes means stored in lists and can be

   they have a common Property  Id and differ on  student <name> course <title>,<price>

   manipulated as the same in one generic class Store<T> 

   
==============================================================================


  compiler error -> 'T' does not contain a definition for 'Id' and no accessible extension method 'Id' accepting a first argument of type 'T' could be found are you missing a using directive or an assembly reference?


  the reason he does not know which T is is a class? if a class does contains a property Id 

  so here i must make a common interface that has Id and make a constraint that implements 

  that  interface 

    where T : class (to enable return null) , IHasId