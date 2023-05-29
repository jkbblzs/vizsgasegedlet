import axios from "axios";
import { useNavigate } from "react-router-dom";
 
export function WebshopCreatePage() {
  const navigate = useNavigate();

  return (
    <div className="p-5 content bg-whitesmoke text-center">
      <h2>Új típus</h2>
      <form 
        onSubmit={(e) => {
          e.preventDefault();
          (async () => {
            try {
              await axios.post("https://localhost:7082/api/UjTipusok", {
                  megnevezes: e.target.elements.megnevezes.value,
                  leiras: e.target.elements.leiras.value,
                  kepek: e.target.elements.kepek.value,
              });
              navigate("/");
            } catch (err) {
              console.log(err);
            }
          })();
          
        }}
      >
        <div className="form-group row pb-3">
          <label className="col-sm-3 col-form-label">Név:</label>
          <div className="col-sm-9">
            <input type="text" name="megnevezes" className="form-control" />
          </div>
        </div>
        <div className="form-group row pb-3">
          <label className="col-sm-3 col-form-label">Leírás:</label>
          <div className="col-sm-9">
            <input type="text" name="leiras" className="form-control" />
          </div>
        </div>
        <div className="form-group row pb-3">
          <label className="col-sm-3 col-form-label">Képfájl neve:</label>
          <div className="col-sm-9">
            <input type="text" name="kepek" className="form-control" />
          </div>
        </div>
        <button type="submit" className="btn btn-success">
          Küldés
        </button>
      </form>
    </div>
  );
}