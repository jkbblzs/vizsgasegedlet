import axios from "axios";
import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";

export function WebshopSinglePage(props) {
    const param = useParams();
    const id = param.tipusId;
    const [tipus, setTipusok] = useState({});
    const [isPending, setPending] = useState(false);
  
    useEffect(() => {
        setPending(true);
          (async () => {
            try {
              const tipusok = await axios.get(`https://localhost:7082/api/Tipusok/${id}`);
              setTipusok(tipusok.data);
            } catch (err) {
              console.log(err);
            } finally {
              setPending(false);
            }
          })();
      }, []);

    return (
        <div className="p-5  m-auto text-center content bg-lavender">
          {isPending || !tipus.id ? (
            <div className="spinner-border"></div>
          ) : (
            <div className="card p-3">
              <div className="card-body">
                <h4 className="card-title">{tipus.megnevezes}</h4>
                <h5>{tipus.leiras}</h5>
                <img
                  className="img-fluid rounded"
                  style={{ maxHeight: "500px" }}
                  src={tipus.kepek ? tipus.kepek : "https://via.placeholder.com/400x800"}
                />
              </div>
            </div>
          )}
        </div>
      );
  }