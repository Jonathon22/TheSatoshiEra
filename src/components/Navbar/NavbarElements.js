import styled from "styled-components";

// eslint-disable-next-line import/prefer-default-export
export const NavigationBar = styled.div`
display: flex;
background: #2C2C2C;
flex-direction: row;
height: 50px;
display: flex;
justify-content: center;
font-size: 1rem;
position: sticky;
top: 0;
z-index: 10;
`;

export const NavLeft = styled.div`
display: flex;
justify-content: left;
align-items: left;
float: left;
`;
export const NavMiddle = styled.div`
display: flex;
flex-direction: row;
float: middle;
`;

export const NavTextMiddle = styled.div`
justify-content: center;
align-items: center;
color: #EEEEEE;
font-size: 30px;
`;

export const NavRight = styled.div`
display: flex;
flex-direction: row;
justify-content: flex-end;
`;
