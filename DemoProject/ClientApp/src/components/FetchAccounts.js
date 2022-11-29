import React, { Component } from 'react';
import { NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';

export class FetchAccounts extends Component {
    static displayName = FetchAccounts.name;

    constructor(props) {
        super(props);
        this.state = { accounts: [], loading: true };
    }

    componentDidMount() {
        this.populateAccounts();
    }

    static renderAccountsTable(accounts) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                        <th>Created On</th>
                        <th>Owner</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
                    {accounts.map(accounts =>
                        <tr key={accounts.id}>
                            <td>{accounts.id}</td>
                            <td>{accounts.name}</td>
                            <td>{new Date(accounts.createdDate).toISOString().slice(0, 10)}</td>
                            <td>{accounts.ownerName}</td>
                            <NavLink tag={Link} className="text-dark" to={"/accounts/"+ accounts.id}>View</NavLink>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : FetchAccounts.renderAccountsTable(this.state.accounts);

        return (
            <div>
                {contents}
            </div>
        );
    }

    async populateAccounts() {
        const response = await fetch('accounts');
        const data = await response.json();
        this.setState({ accounts: data, loading: false });
    }
}
