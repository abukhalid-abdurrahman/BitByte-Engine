using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GameEngine_Project
{
    class Components_Form
    {
        public void Show()
        {
            #region Form
            Form ComponentForm = new Form();
            ComponentForm.Name = "ComponentsForm";
            ComponentForm.Text = "Компоненты";
            ComponentForm.StartPosition = FormStartPosition.CenterScreen;
            ComponentForm.Size = new Size(300, 300);
            ComponentForm.MaximizeBox = false;
            ComponentForm.MinimizeBox = false;
            ComponentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            ComponentForm.ShowIcon = false;
            #endregion

            #region TreeView

            #region Fields

            #region Mesh
            TreeNode treeNodeMeshFilter = new TreeNode("Mesh Filter");
            TreeNode treeNodeMeshRenderer = new TreeNode("Mesh Renderer");
            #endregion
            #region Effects
            TreeNode treeNodeParticleSystem = new TreeNode("Particle System");
            TreeNode treeNodeLensFlare = new TreeNode("Lens Flare");
            TreeNode treeNodeHalo = new TreeNode("Halo");
            #endregion
            #region Physics Node
            TreeNode treeNodeRigidbody = new TreeNode("RigidBody");
            TreeNode treeNodeBoxCollider = new TreeNode("Box Collider");
            TreeNode treeNodeSphereCollider = new TreeNode("Sphere Collider");
            TreeNode treeNodeCapsuleCollider = new TreeNode("Capsule Collider");
            TreeNode treeNodeMeshCollider = new TreeNode("Mesh Collider");
            TreeNode treeNodeWheelCollider = new TreeNode("Wheel Collider");
            #endregion
            #region Physics2D Nodes
            TreeNode treeNodeRigidbody2D = new TreeNode("RigidBody 2D");
            TreeNode treeNodeBoxCollider2D = new TreeNode("Box Collider 2D");
            TreeNode treeNodeCircleCollider2D = new TreeNode("Circle Collider 2D");
            TreeNode treeNodePolygonCollider2D = new TreeNode("Polygon Collider 2D");
            TreeNode treeNodeEdgeCollider2D = new TreeNode("Edge Collider 2D");
            #endregion
            #region Navigation
            TreeNode treeNodeNavMeshAgent = new TreeNode("Nav Mesh Agent");
            TreeNode treeNodeOffMeshLink = new TreeNode("Off Mesh Link");
            TreeNode treeNodeNavMeshObstacle = new TreeNode("Nav Mesh Obstacle");
            TreeNode treeNodeWayPoint = new TreeNode("Way Point");
            #endregion
            #region Audio
            TreeNode treeNodeAudioPlayArea = new TreeNode("Audio Play Area");
            TreeNode treeNodeAudioListener = new TreeNode("Audio Listener");
            #endregion
            #region Animation
            TreeNode treeNodeAnimation = new TreeNode("Animation");
            TreeNode treeNodeAnimator = new TreeNode("Animator");
            #endregion

            TreeNode treeNodeScripts = new TreeNode("Scripts");
            TreeNode treeNodeAnimations = new TreeNode("Animations");
            TreeNode treeNodeAudio = new TreeNode("Audio");
            TreeNode treeNodeNavigation = new TreeNode("Navigation");
            TreeNode treeNodePhysics2D = new TreeNode("Physics 2D");
            TreeNode treeNodePhysics = new TreeNode("Physics");
            TreeNode treeNodeEffects = new TreeNode("Effects");
            TreeNode treeNodeMesh = new TreeNode("Mesh");
            TreeView treeView = new TreeView();
            #endregion

            #region TreeViewComponents
            treeView.Name = "ComponentsTreeView";
            treeView.Dock = DockStyle.Fill;
            treeView.BorderStyle = BorderStyle.Fixed3D;

            treeView.Nodes.AddRange(new TreeNode[]{
                treeNodeMesh,
                treeNodeEffects,
                treeNodePhysics,
                treeNodePhysics2D,
                treeNodeNavigation,
                treeNodeAudio,
                treeNodeAnimations,
                treeNodeScripts
        });
            #endregion

            #region TreeNodes
            //Полисетка
            treeNodeMesh.Nodes.AddRange(new TreeNode []{
            treeNodeMeshFilter,
            treeNodeMeshRenderer
            });

            //Эффекты
            treeNodeEffects.Nodes.AddRange(new TreeNode[]{
            treeNodeParticleSystem,
            treeNodeLensFlare,
            treeNodeHalo
            });

            //Физика
            treeNodePhysics.Nodes.AddRange(new TreeNode[]{
            treeNodeRigidbody,
            treeNodeBoxCollider,
            treeNodeSphereCollider,
            treeNodeCapsuleCollider,
            treeNodeMeshCollider,
            treeNodeWheelCollider            
            });

            //Физика 2D
            treeNodePhysics2D.Nodes.AddRange(new TreeNode[]{
            treeNodeRigidbody2D,
            treeNodeBoxCollider2D,
            treeNodeCircleCollider2D,
            treeNodePolygonCollider2D,
            treeNodeEdgeCollider2D
            });

            //Навигация
            treeNodeNavigation.Nodes.AddRange(new TreeNode[]{
            treeNodeNavMeshAgent,
            treeNodeOffMeshLink,
            treeNodeNavMeshObstacle,
            treeNodeWayPoint
            });

            //Звук
            treeNodeAudio.Nodes.AddRange(new TreeNode[]{
            treeNodeAudioPlayArea,
            treeNodeAudioListener
            });

            //Анимация
            treeNodeAnimations.Nodes.AddRange(new TreeNode[]{
            treeNodeAnimation,
            treeNodeAnimator
            });
            #endregion

            ComponentForm.Controls.Add(treeView);

            #endregion
          
            ComponentForm.ShowDialog();
        }
    }
}
