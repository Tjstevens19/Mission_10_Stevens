import { useEffect } from 'react';
import { useState } from 'react';
import { Bowler } from '../types/Bowler';

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<Bowler[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('http://localhost:5166/Bowler/GetBowlers');
      const f = await rsp.json();
      setBowlerData(f);
    };
    fetchBowlerData();
  }, []);
  return (
    <>
      <div>
        <h4>Bowler List</h4>
        <table className="table table-striped">
          <thead>
            <tr>
              <th>First Name</th>
              <th>Middle Initial</th>
              <th>Last Name</th>
              <th>Team Name</th>
              <th>Address</th>
              <th>City</th>
              <th>State</th>
              <th>Zip</th>
              <th>Phone Number</th>
            </tr>
          </thead>
          <tbody>
            {bowlerData.map(
              (
                bowler, // Display bowler data
              ) => (
                <tr key={bowler.bowlerId}>
                  <td>{bowler.bowlerFirstName}</td>
                  <td>{bowler.bowlerMiddleInit}</td>
                  <td>{bowler.bowlerLastName}</td>
                  <td>{bowler.teamName}</td> {/* Display teamName */}
                  <td>{bowler.bowlerAddress}</td>
                  <td>{bowler.bowlerCity}</td>
                  <td>{bowler.bowlerState}</td>
                  <td>{bowler.bowlerZip}</td>
                  <td>{bowler.bowlerPhoneNumber}</td>
                </tr>
              ),
            )}
          </tbody>
        </table>
      </div>
    </>
  );
}

export default BowlerList;
