using System;

using NHapi.Base.Model;
namespace NHapi.Model.V23UCH.Datatype
{
/// <summary>/// Summary description for DT.
/// </summary>
public class DT: NHapi.Base.Model.Primitive.DT
{
/// <summary>Return the version
/// <returns>2.3.UCH</returns>
///</summary>

            virtual public System.String Version
            {
			    get
			    {
				    return "2.3.UCH";
			    }
		    }
            


                ///<summary>Construct the type
                ///<param name="theMessage">message to which this Type belongs</param>
                ///</summary>
                public DT(IMessage theMessage):base(theMessage)
                {}
                


                ///<summary>Construct the type
                ///<param name="message">message to which this Type belongs</param>
                ///<param name="description">The description of this type</param>
                ///</summary>
		        public DT(IMessage message, string description) : base(message,description)
    	        {}
                }}