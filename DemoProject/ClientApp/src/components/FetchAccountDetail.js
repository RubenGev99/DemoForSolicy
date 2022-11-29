import React, { Component } from 'react';
import { useParams, useNavigate } from "react-router-dom";


export class FetchAccountDetail extends Component {
    static displayName = FetchAccountDetail.name;

    constructor(props) {
      super(props);

      this.state = { accounts: [], loading: true };
  }

  componentDidMount() {
      this.populateAccounts();
  }
  static renderAccountDetailTable(accounts) {
    return (
        <table className='table table-striped' aria-labelledby="tabelLabel">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Created On</th>
                    <th>Updated On</th>
                    <th>Owner</th>
                </tr>
            </thead>
            <tbody>
                {
                    <tr key={accounts.id}>
                        <td>{accounts.id}</td>
                        <td>{accounts.name}</td>
                        <td>{new Date(accounts.createdDate).toISOString().slice(0, 10)}</td>
                        <td>{new Date(accounts.updatedDate).toISOString().slice(0, 10)}</td>
                        <td>{accounts.ownerName}</td>
                    </tr>
                }
            </tbody>
        </table>
    );
}
  render() {
    let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : FetchAccountDetail.renderAccountDetailTable(this.state.accounts);

        return (
            <div>
                {contents}
            </div>
        );
  }

  async populateAccounts() {
      const id = window.location.pathname.split('/')[2];
      const response = await fetch('accounts/'+id);
    const data = await response.json();
    this.setState({ accounts: data, loading: false });
}
}
