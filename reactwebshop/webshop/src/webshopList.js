import axios from "axios";
import { useEffect, useState } from "react";
import { NavLink } from "react-router-dom";

export function WebshopList() {
    const [tipusok, setTipusok] = useState([]);
    const [isFetchPending, setFetchPending] = useState(false);
    
    useEffect(() => {
        setFetchPending(true);
        (async() => {
            try {
                const tipusok = await axios.get("https://localhost:7082/api/Tipusok");
                setTipusok(tipusok.data);
            } catch (err) {
                console.log(err);
            } finally {
                setFetchPending(false);
            }
        })();
      }, []);
    
    return (
        <div className="p-5  m-auto text-center content bg-ivory">
          {isFetchPending ? (
            <div className="spinner-border"></div>
          ) : (
            <div>
              <h2>Típusok:</h2>
              {tipusok.map((tipus) => (
                <NavLink key={tipus.id} to={"/Tipusok/" + tipus.id}>
                  <div className="card col-sm-3 d-inline-block m-1 p-2">
                    <h6 className="text-muted">{tipus.megnevezes}</h6>
                    <h5 className="text-dark">{tipus.leiras}</h5>
                    <div className="card-body">
                      <img
                        className="img-fluid"
                        style={{ maxHeight: 200 }}
                        src={tipus.kepek}
                      />
                    </div>
                  </div>
                  </NavLink>
              ))}
            </div>
          )}
        </div>
      );
  }