import React from 'react'
import PropTypes from 'prop-types';
import { FaBars } from 'react-icons/fa';
import {
    NavigationBar,
    NavLeft,
    NavMiddle,
    NavTextMiddle,
    NavRight,
} from './NavbarElements';

export default function Navbar() {
const styledBars = {
    color: '#EEEEEE',
    margin: '5px',
}
    return (
        <NavigationBar>
            <NavLeft className="NavLeft">
            <FaBars className='FaBars' style={styledBars} />
            </NavLeft>
            <NavMiddle className="NavMiddle">
                <NavTextMiddle className='MiddleText'>
                    THE SATOSHI ERA 
                </NavTextMiddle>
            </NavMiddle>
            <NavRight>
            </NavRight>
        </NavigationBar>
    )
}