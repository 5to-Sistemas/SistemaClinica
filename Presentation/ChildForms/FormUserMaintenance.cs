﻿using Common;
using Domain;
using Presentation.Helpers;
using Presentation.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.ChildForms
{
    public partial class FormUserMaintenance : BaseForms.BaseFixedForm
    {
        /// <summary>
        /// Esta clase hereda de la clase BaseFixedForm.
        /// </summary>
        /// 

        #region -> Campos

        private UserModel userModel;//Obtiene o establece el modelo de dominio de usuario.
        private bool userModify; //Obtiene o establece un usuario será editado.
        private int userId;//Obtiene o establece el id del usuario a editar.
        private Image defaultPhoto = Properties.Resources.DefaultUserProfile;//Foto predeterminada para usuarios que no tienen una foto agregada.
        private PatientsModel pacientmodel = new PatientsModel();
        private MedicalModel medicmodel = new MedicalModel();

        #endregion

        #region -> Constructores

        public FormUserMaintenance()
        {//Utilice este constructor cuando desee agregar un nuevo usuario.

            InitializeComponent();
            lblCaption.Text = "Agregar nuevo usuario";
            userModel = new UserModel();//Inicializar modelo de dominio de usuario.
            userModify = false;//Establecer userModify en falso.
            PictureBoxPhoto.Image = defaultPhoto; //Establecer la foto predeterminada para los usuarios sin foto.
            cmbPosition.DataSource = Positions.GetPositions();//Establecer lista de cargos.
            cmbPosition.SelectedIndex = -1;//Sin seleccion de indice.
        }
        public FormUserMaintenance(UserModel _userModel, bool isUserProfile)
        {//Utilice este constructor cuando desee editar un usuario o actualizar el perfil de usuario.

            InitializeComponent();
            this.TitleBarColor = Color.MediumSeaGreen;
            btnSave.BackColor = Color.MediumSeaGreen;
            cmbPosition.DataSource = Positions.GetPositions();

            userModel = _userModel;//Establecer modelo de dominio de usuario.
            userModify = true;  //Establecer userModify en verdadero.
            FillFields();   //LLenar los campos del formulario con el modelo de usuario (Ver metodo).                 
            if (isUserProfile) //Si la edicion es del perfil de usuario, cambiar titulo y desactivar los cargos.
            {
                lblCaption.Text = "Actualizar mi perfil de usuario";
                cmbPosition.Enabled = false;
            }
            else //Caso contrario mostrar titulo  modificar usuario.
                lblCaption.Text = "Modificar usuario";
        }
        #endregion

        #region -> Métodos

        private void FillFields()
        {//Cargar los datos del modelo  en los campos del formulario.
            userId = userModel.Id;
            txtUsername.Text = userModel.Username;
            txtPassword.Text = userModel.Password;
            txtConfirmPass.Text = userModel.Password;
            txtFirstName.Text = userModel.FirstName;
            txtLastName.Text = userModel.LastName;
            cmbPosition.Text = userModel.Position;
            txtEmail.Text = userModel.Email;
            if (userModel.Photo != null)
                PictureBoxPhoto.Image = ItemConverter.BinaryToImage(userModel.Photo);
            else PictureBoxPhoto.Image = defaultPhoto;

            try
            {
                if (userModel.Position == "Medico")
                {
                    DataTable dt = new DataTable();
                    //string iduser = medicmodel.obteneriddeuserbyusername(userModel.Username);
                    dt = medicmodel.Mostrartablade1medico(userId.ToString()).Copy();
                    txbci.Text = dt.Rows[0][1].ToString();
                    txbdireccion.Text = dt.Rows[0][2].ToString();
                    txbtelefono.Text = dt.Rows[0][3].ToString();
                    txbdiashabi.Text = dt.Rows[0][4].ToString();
                    txbhoraini.Text = dt.Rows[0][5].ToString();
                    txbhorafin.Text = dt.Rows[0][6].ToString();
                    cmbxespecialidad.Text = dt.Rows[0][7].ToString();
                    cmbxsexo.Text = dt.Rows[0][8].ToString();
                }
                if (userModel.Position == "Paciente")
                {
                    DataTable dt = new DataTable();
                    string iduser = pacientmodel.obteneriddeuserbyusername(userModel.Username);
                    dt = pacientmodel.Mostrartablade1paciente(iduser).Copy();
                    txbci.Text = dt.Rows[0][1].ToString();
                    txbdireccion.Text = dt.Rows[0][2].ToString();
                    dtpfechanac.Value = Convert.ToDateTime(dt.Rows[0][3]);
                    cmbxtiposangre.Text = dt.Rows[0][4].ToString();
                    txbtelefono.Text = dt.Rows[0][5].ToString();
                    cmbxsexo.Text = dt.Rows[0][6].ToString();
                    cmbxestadocivil.Text = dt.Rows[0][7].ToString();
                    cmbxstate.Text = dt.Rows[0][8].ToString();

                }
            }
            catch
            {

            }

            

        }
        private void FillUserModel()
        {//LLenar modelo

            userModel.Id = userId;
            userModel.Username = txtUsername.Text;
            userModel.Password = txtPassword.Text;
            userModel.FirstName = txtFirstName.Text;
            userModel.LastName = txtLastName.Text;
            userModel.Position = cmbPosition.Text;
            userModel.Email = txtEmail.Text;
            if (PictureBoxPhoto.Image == defaultPhoto)
                userModel.Photo = null;
            else userModel.Photo = ItemConverter.ImageToBinary(PictureBoxPhoto.Image);

        }
        private void Save()
        {//Guardar cambios.
            int result = -1;
            try
            {
                FillUserModel();//Obtener modelo de vista.
                var validateData = new DataValidation(userModel);//Validar campos del objeto.
                var validatePassword = txtPassword.Text == txtConfirmPass.Text;//Validar contraseñas.

                if (validateData.Result == true && validatePassword == true)//Si el objeto y contraseña es válido.
                {
                    //EDITAR USUARIO
                    if (userModify == true)
                    {
                        result = userModel.ModifyUser();//Invocar metodo ModifyUser del modelo de usuario.
                        if (result > 0)
                        {
                            if (cmbPosition.Text == "Medico")
                            {
                                string iduser = medicmodel.obteneriddeuserbyusername(txtUsername.Text);
                                if (medicmodel.existemedico(iduser))
                                {
                                    medicmodel.Editar(iduser, txbci.Text, txbdireccion.Text, txbtelefono.Text, txbdiashabi.Text, txbhoraini.Text, txbhorafin.Text, cmbxespecialidad.Text, cmbxsexo.Text);
                                }
                                else
                                {
                                    medicmodel.Insertar(iduser, txbci.Text, txbdireccion.Text, txbtelefono.Text, txbdiashabi.Text, txbhoraini.Text, txbhorafin.Text, cmbxespecialidad.Text, cmbxsexo.Text);
                                }
                                
                                
                                
                                
                                
                            }
                            if (cmbPosition.Text == "Paciente")
                            {
                                
                                string iduser = pacientmodel.obteneriddeuserbyusername(txtUsername.Text);
                                if (pacientmodel.existepaciente(iduser)) 
                                {
                                    pacientmodel.Editar(iduser, txbci.Text, txbdireccion.Text, dtpfechanac.Value.ToString(), cmbxtiposangre.Text, txbtelefono.Text, cmbxsexo.Text, cmbxestadocivil.Text, cmbxstate.Text);
                                }
                                else
                                {
                                    
                                    pacientmodel.Insertar(iduser, txbci.Text, txbdireccion.Text, dtpfechanac.Value.ToString(), cmbxtiposangre.Text, txbtelefono.Text, cmbxsexo.Text, cmbxestadocivil.Text, cmbxstate.Text);
                                }
                                
                                

                            }
                            MessageBox.Show("Usuario actualizado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = System.Windows.Forms.DialogResult.OK;//Establecer Ok como resultado de dialogo del formulario.
                            this.Close();//Cerrar formulario
                        }
                        else
                        {
                            MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    //AGREGAR USUARIO
                    else
                    {
                        result = userModel.CreateUser(); //Invocar metodo CreateUser del modelo de usuario.

                        if (result > 0)
                        {
                            if (cmbPosition.Text == "Medico")
                            {
                                string iduser = medicmodel.obteneriddeuserbyusername(txtUsername.Text);
                                medicmodel.Insertar(iduser, txbci.Text,txbdireccion.Text,txbtelefono.Text,txbdiashabi.Text,txbhoraini.Text,txbhorafin.Text,cmbxespecialidad.Text,cmbxsexo.Text);
                            }
                            if (cmbPosition.Text == "Paciente")
                            {
                                string iduser = pacientmodel.obteneriddeuserbyusername(txtUsername.Text);
                                pacientmodel.Insertar(iduser,txbci.Text,txbdireccion.Text,dtpfechanac.Value.ToString(),cmbxtiposangre.Text,txbtelefono.Text,cmbxsexo.Text,cmbxestadocivil.Text,cmbxstate.Text);
                                

                            }
                            
                            MessageBox.Show("Usuario agregado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = System.Windows.Forms.DialogResult.OK; //Establecer Ok como resultado de dialogo del formulario.
                            this.Close();//Cerrar formulario
                        }
                        else
                        {
                            MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else //Si el objeto o contraseña NO es válido, mostrar mensaje segun el caso.
                {
                    if (validateData.Result == false)
                        MessageBox.Show(validateData.ErrorMessage, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                        MessageBox.Show("Las contraseñas no coinciden", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                var message = ExceptionManager.GetMessage(ex);//Obtener mensaje de excepción.
                MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mostrar mensaje.
            }
        }
        #endregion

        #region -> Metodos de evento

        private void FormUserMaintenance_Load(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();//Guardar cambios.
        }
        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            //Agregar una imagen al cuadro de imagen para la foto del usuario.
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Images(.jpg,.png)|*.png;*.jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                PictureBoxPhoto.Image = new Bitmap(openFile.FileName);
            }
        }

        private void btnDeletePhoto_Click(object sender, EventArgs e)
        {
            //Borrar foto del usuario
            PictureBoxPhoto.Image = defaultPhoto;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPosition.Text == "Medico")
            {
                panelcomun.Enabled = true;
                panelmedico.Enabled = true;
                panelpaci.Enabled = false;
            }
            else if (cmbPosition.Text == "Paciente")
            {
                panelcomun.Enabled = true;
                panelpaci.Enabled = true;
                panelmedico.Enabled = false;
            }
            else
            {
                panelcomun.Enabled = false;
                panelmedico.Enabled = false;
                panelpaci.Enabled = false;
            }
        }
    }
}
