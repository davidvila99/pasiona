import React, {Component} from 'react';
import './App.css';

class EditPlayer extends Component {
    constructor(props) {
        super(props);
        this.state = {
            id: this.props.id,
            name: this.props.name,
            mail: this.props.mail,
            username: this.props.username
        };
    }

    cambio = (event) =>{
        const {name,value} = event.target;
        this.setState({
            [name]:value,
            id:this.props.id
        });
    }

    Edit = () => {
        const params={
            method:'PUT',
            body:JSON.stringify(this.state),
            headers:{ "Content-type": "application/json; charset=UTF-8"}
        }
        console.log(this.state)
        console.log(params)
        console.log('https://localhost:44375/api/Players/'+this.props.id)
        fetch('https://localhost:44375/api/Players/'+this.props.id, params)
        .then(response => response.json)
        .then(json=>{
            this.setState({
                name: "",
                mail: "",
                username: ""
            }) 
        })
        .catch(error => console.log(error));
    }

    render(){
        return(
            <div>
            <label>Name:</label>
            <input name="name" value={this.state.name} onChange={this.cambio}></input>
            <label>Mail:</label>
            <input name="mail" value={this.state.mail} onChange={this.cambio}></input>
            <label>Username:</label>
            <input name="username" value={this.state.username} onChange={this.cambio}></input>
            <button onClick={this.Edit}>Edit</button>
            </div>
        )
    }
}

export default EditPlayer;